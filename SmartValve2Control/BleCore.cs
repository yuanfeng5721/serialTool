using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Networking;
using Windows.Networking.Proximity;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;

namespace SmartValve2Control
{
    public class BleCore
    {
        //存储检测的设备MAC。
        public string CurrentDeviceMAC { get; set; }
        public string CurrentDeviceName { get; set; }
        //存储检测到的设备。
        public BluetoothLEDevice CurrentDevice { get; set; }
        //存储检测到的主服务。
        public GattDeviceService CurrentService { get; set; }
        //存储检测到的写特征对象。
        public GattCharacteristic CurrentWriteCharacteristic { get; set; }
        //存储检测到的通知特征对象。
        public GattCharacteristic CurrentNotifyCharacteristic { get; set; }

        public string ServiceGuid { get; set; }

        public string WriteCharacteristicGuid { get; set; }
        public string NotifyCharacteristicGuid { get; set; }


        private int CHARACTERISTIC_INDEX = 0;
        //特性通知类型通知启用
        private const GattClientCharacteristicConfigurationDescriptorValue CHARACTERISTIC_NOTIFICATION_TYPE = GattClientCharacteristicConfigurationDescriptorValue.Notify;
        
        private Boolean asyncLock = false;

        private DeviceWatcher deviceWatcher;
        private Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher Watcher = null;

        /// <summary>
        /// 存储检测到的设备
        /// </summary>
        public List<BluetoothLEDevice> DeviceList { get; private set; }

        private Boolean bConnected = false;

        //定义一个委托
        public delegate void eventRun(MsgType type, string str, byte[] data = null);
        public delegate void eventReceive(int receivebytes, byte[] data);
        public delegate void updateDevice(string devname);
        public delegate void searchStoped();
        //定义一个事件
        public event eventRun ValueChanged;
        public event eventReceive Receive;
        public event updateDevice UpdateDevcice;
        public event searchStoped SearchStoped;

        public BleCore(string serviceGuid, string writeCharacteristicGuid, string notifyCharacteristicGuid)
        {
            DeviceList = new List<BluetoothLEDevice>();
            ServiceGuid = serviceGuid;
            WriteCharacteristicGuid = writeCharacteristicGuid;
            NotifyCharacteristicGuid = notifyCharacteristicGuid;
        }

        public void StartBleDeviceWatcher()
        {
            string[] requestedProperties = { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected", "System.Devices.Aep.Bluetooth.Le.IsConnectable" };

            // BT_Code: Example showing paired and non-paired in a single query.
            string aqsAllBluetoothLEDevices = "(System.Devices.Aep.ProtocolId:=\"{bb7bb05e-5972-42b5-94fc-76eaa7084d49}\")";

            deviceWatcher =
                    DeviceInformation.CreateWatcher(
                        aqsAllBluetoothLEDevices,
                        requestedProperties,
                        DeviceInformationKind.AssociationEndpoint);

            // Register event handlers before starting the watcher.
            deviceWatcher.Added += DeviceWatcher_Added;
            deviceWatcher.Stopped += DeviceWatcher_Stopped;
            deviceWatcher.Start();
            string msg = "自动发现设备中..";

            ValueChanged(MsgType.NotifyTxt, msg);
        }

        /// <summary>
        /// 搜索蓝牙设备
        /// </summary>
        public void StartBleDeviceWatcher2()
        {
            Watcher = new Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher();

            Watcher.ScanningMode = Windows.Devices.Bluetooth.Advertisement.BluetoothLEScanningMode.Active;

            // only activate the watcher when we're recieving values >= -80
            Watcher.SignalStrengthFilter.InRangeThresholdInDBm = -80;

            // stop watching if the value drops below -90 (user walked away)
            Watcher.SignalStrengthFilter.OutOfRangeThresholdInDBm = -90;

            // register callback for when we see an advertisements
            Watcher.Received += OnAdvertisementReceived;
            Watcher.Stopped += OnAdvertisementStoped;

            // wait 5 seconds to make sure the device is really out of range
            Watcher.SignalStrengthFilter.OutOfRangeTimeout = TimeSpan.FromMilliseconds(5000);
            Watcher.SignalStrengthFilter.SamplingInterval = TimeSpan.FromMilliseconds(2000);

            DeviceList.RemoveRange(0, DeviceList.Count);

            // starting watching for advertisements
            Watcher.Start();

            string msg = "自动发现设备中..";

            ValueChanged(MsgType.NotifyTxt, msg);
        }

        public void StopBleDeviceWatcher()
        {
            if (deviceWatcher != null)
            {
                // Unregister the event handlers.
                deviceWatcher.Added -= DeviceWatcher_Added;
                deviceWatcher.Stopped -= DeviceWatcher_Stopped;

                // Stop the watcher.
                deviceWatcher.Stop();
                deviceWatcher = null;
            }
        }

        /// <summary>
        /// 停止搜索蓝牙
        /// </summary>
        public void StopBleDeviceWatcher2()
        {
            if (Watcher != null)
            {
                Watcher.Stop();
                Watcher.Received -= OnAdvertisementReceived;
                Watcher.Stopped -= OnAdvertisementStoped;      
                Watcher = null;
                //Console.WriteLine("停止发现设备..");
            }
        }

        private void DeviceWatcher_Stopped(DeviceWatcher sender, object args)
        {
            string msg = "自动发现设备停止";
            ValueChanged(MsgType.NotifyTxt, msg);
        }

        private void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            if (CurrentDeviceMAC != null && args.Id.EndsWith(CurrentDeviceMAC))
            {
                ValueChanged(MsgType.NotifyTxt, "发现设备:" + args.Name);
                Matching(args.Id);
            }
            else if (CurrentDeviceName != null && args.Name.EndsWith(CurrentDeviceName))
            {
                ValueChanged(MsgType.NotifyTxt, "发现设备:" + args.Name);
                Matching(args.Id);
            }

            //UpdateDevcice?.Invoke(args);

        }

        private void OnAdvertisementStoped(Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher watcher, Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStoppedEventArgs eventArgs)
        {
            SearchStoped?.Invoke();
        }

        private void OnAdvertisementReceived(Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher watcher, Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs eventArgs)
        {
            BluetoothLEDevice.FromBluetoothAddressAsync(eventArgs.BluetoothAddress).Completed = (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    if (asyncInfo.GetResults() == null)
                    {
                        //Console.WriteLine("没有得到结果集");
                    }
                    else
                    {
                        BluetoothLEDevice currentDevice = asyncInfo.GetResults();

                        //if (currentDevice.Name == CurrentDeviceName)
                        {
                            if (DeviceList.FindIndex((x) => { return x.Name.Equals(currentDevice.Name); }) < 0)
                            {
                                CurrentDevice = currentDevice;
                                this.DeviceList.Add(CurrentDevice);
                                //Matching(currentDevice.DeviceId);
                                UpdateDevcice?.Invoke(currentDevice.Name);
                            }
                        }
                        //if (DeviceList.FindIndex((x) => { return x.Name.Equals(currentDevice.Name); }) < 0)
                        //{
                        //    this.DeviceList.Add(currentDevice);
                        //    DeviceWatcherChanged?.Invoke(currentDevice);
                        //}

                    }

                }
            };
        }

        /// <summary>
        /// 按MAC地址查找系统中配对设备
        /// </summary>
        /// <param name="MAC"></param>
        public async Task SelectDevice(string MAC)
        {
            CurrentDeviceMAC = MAC;
            CurrentDevice = null;
            DeviceInformation.FindAllAsync(BluetoothLEDevice.GetDeviceSelector()).Completed = async (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    DeviceInformationCollection deviceInformation = asyncInfo.GetResults();
                    foreach (DeviceInformation di in deviceInformation)
                    {
                        await Matching(di.Id);
                    }
                    if (CurrentDevice == null)
                    {
                        string msg = "没有发现设备";
                        ValueChanged(MsgType.NotifyTxt, msg);
                        StartBleDeviceWatcher();
                    }
                }
            };
        }
        /// <summary>
        /// 按MAC地址直接组装设备ID查找设备
        /// </summary>
        /// <param name="MAC"></param>
        /// <returns></returns>
        public async Task SelectDeviceFromIdAsync(string MAC)
        {
            CurrentDeviceMAC = MAC;
            CurrentDevice = null;
            BluetoothAdapter.GetDefaultAsync().Completed = async (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    BluetoothAdapter mBluetoothAdapter = asyncInfo.GetResults();
                    byte[] _Bytes1 = BitConverter.GetBytes(mBluetoothAdapter.BluetoothAddress);//ulong转换为byte数组
                    Array.Reverse(_Bytes1);
                    string macAddress = BitConverter.ToString(_Bytes1, 2, 6).Replace('-', ':').ToLower();
                    string Id = "BluetoothLE#BluetoothLE" + macAddress + "-" + MAC;
                    await Matching(Id);
                }

            };

        }

        private async Task Matching(string Id)
        {
            try
            {
                BluetoothLEDevice.FromIdAsync(Id).Completed = async (asyncInfo, asyncStatus) =>
                {
                    if (asyncStatus == AsyncStatus.Completed)
                    {
                        BluetoothLEDevice bleDevice = asyncInfo.GetResults();
                        //在当前设备变量中保存检测到的设备。
                        CurrentDevice = bleDevice;
                        //await Connect();
                        FindService();
                    }
                };
            }
            catch (Exception e)
            {
                string msg = "没有发现设备" + e.ToString();
                ValueChanged(MsgType.NotifyTxt, msg);
                //StartBleDeviceWatcher();
                ValueChanged(MsgType.NotifyStates, "No Found");
            }
        }

        /// <summary>
        /// 获取特性
        /// </summary>
        private void FindCharacteristic(GattDeviceService gattDeviceService)
        {
            this.CurrentService = gattDeviceService;
            this.CurrentService.GetCharacteristicsAsync().Completed = (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    var services = asyncInfo.GetResults().Characteristics;
                    foreach (GattCharacteristic c in services)
                    {
                        //this.CharacteristicAdded?.Invoke(c);
                        //Matching(string Id);
                        ValueChanged(MsgType.NotifyTxt, "GattCharacteristic uuid=" + c.Uuid.ToString());
                        if(c.Uuid.ToString() == WriteCharacteristicGuid)
                        {
                            CurrentWriteCharacteristic = c;
                        }
                        if (c.Uuid.ToString() == NotifyCharacteristicGuid)
                        {
                            CurrentNotifyCharacteristic = c;
                            CurrentNotifyCharacteristic.ProtectionLevel = GattProtectionLevel.Plain;
                            CurrentNotifyCharacteristic.ValueChanged += Characteristic_ValueChanged;
                            EnableNotifications(CurrentNotifyCharacteristic);
                        }
                    }

                }
            };
        }

        /// 获取蓝牙服务
        /// </summary>
        public void FindService()
        {
            this.CurrentDevice.GetGattServicesAsync().Completed = (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    var services = asyncInfo.GetResults().Services;
                    ValueChanged(MsgType.NotifyTxt, "GattServices size=" + services.Count);
                    foreach (GattDeviceService ser in services)
                    {
                        ValueChanged(MsgType.NotifyTxt, "GattServices uuid=" + ser.Uuid.ToString());
                        FindCharacteristic(ser);
                    }
                    //CharacteristicFinish?.Invoke(services.Count);
                }
            };

        }

        public void Connect(string devname)
        {
            string id = null;
            foreach(BluetoothLEDevice dev in DeviceList)
            {
                if(dev.Name == devname)
                {
                    id = dev.DeviceId;
                    ValueChanged(MsgType.NotifyTxt, "device id=" + id);
                    break;
                }
            }
            if(id != null)
            {
                Matching(id);
            }
            
        }

        private async Task Connect()
        {
            string msg = "正在连接设备<" + CurrentDeviceMAC + ">..";
            ValueChanged(MsgType.NotifyTxt, msg);
            CurrentDevice.ConnectionStatusChanged += CurrentDevice_ConnectionStatusChanged;
            await SelectDeviceService();

        }


        /// <summary>
        /// 主动断开连接
        /// </summary>
        /// <returns></returns>
        public void Dispose()
        {
            ValueChanged(MsgType.NotifyTxt, "主动断开连接");
            bConnected = false;
            CurrentDeviceName = null;
            CurrentDeviceMAC = null;
            CurrentService?.Dispose();
            CurrentDevice?.Dispose();
            //CurrentDevice.ConnectionStatusChanged -= CurrentDevice_ConnectionStatusChanged;
            CurrentDevice = null;
            CurrentService = null;
            CurrentWriteCharacteristic = null;
            CurrentNotifyCharacteristic = null;
            ValueChanged(MsgType.NotifyStates, "Success");

        }

        private void CurrentDevice_ConnectionStatusChanged(BluetoothLEDevice sender, object args)
        {
            if (sender.ConnectionStatus == BluetoothConnectionStatus.Disconnected && CurrentDeviceMAC != null)
            {
                string msg = "设备已断开,自动重连";
                ValueChanged(MsgType.NotifyTxt, msg);
                if (!asyncLock)
                {
                    asyncLock = true;
                    CurrentDevice.Dispose();
                    CurrentDevice = null;
                    CurrentService = null;
                    CurrentWriteCharacteristic = null;
                    CurrentNotifyCharacteristic = null;
                    SelectDeviceFromIdAsync(CurrentDeviceMAC);
                }

            }
            else if(CurrentDeviceMAC != null)
            {
                bConnected = true;
                string msg = "设备已连接";
                ValueChanged(MsgType.NotifyTxt, msg);
            }
        }
        /// <summary>
        /// 按GUID 查找主服务
        /// </summary>
        /// <param name="characteristic">GUID 字符串</param>
        /// <returns></returns>
        public async Task SelectDeviceService()
        {
            Guid guid = new Guid(ServiceGuid);
            CurrentDevice.GetGattServicesForUuidAsync(guid).Completed = (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    //if(bConnected)
                    {
                        try
                        {
                            GattDeviceServicesResult result = asyncInfo.GetResults();
                            string msg = "主服务=" + result.Status;
                            ValueChanged(MsgType.NotifyTxt, msg);
                            if (result.Services.Count > 0)
                            {
                                CurrentService = result.Services[CHARACTERISTIC_INDEX];
                                if (CurrentService != null)
                                {
                                    asyncLock = true;
                                    GetCurrentWriteCharacteristic();
                                    GetCurrentNotifyCharacteristic();

                                }
                            }
                            else
                            {
                                msg = "没有发现服务,自动重试中";
                                ValueChanged(MsgType.NotifyTxt, msg);
                                SelectDeviceService();
                            }
                        }
                        catch (Exception e)
                        {
                            ValueChanged(MsgType.NotifyTxt, "没有发现服务,自动重试中");
                            SelectDeviceService();

                        }
                    }
                }
            };
        }


        /// <summary>
        /// 设置写特征对象。
        /// </summary>
        /// <returns></returns>
        public async Task GetCurrentWriteCharacteristic()
        {

            string msg = "";
            Guid guid = new Guid(WriteCharacteristicGuid);
            CurrentService.GetCharacteristicsForUuidAsync(guid).Completed = async (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    GattCharacteristicsResult result = asyncInfo.GetResults();
                    msg = "特征对象=" + result.Status;
                    ValueChanged(MsgType.NotifyTxt, msg);
                    if (result.Characteristics.Count > 0)
                    {
                        CurrentWriteCharacteristic = result.Characteristics[CHARACTERISTIC_INDEX];
                    }
                    else
                    {
                        msg = "没有发现特征对象,自动重试中";
                        ValueChanged(MsgType.NotifyTxt, msg);
                        await GetCurrentWriteCharacteristic();
                    }
                }
            };
        }




        /// <summary>
        /// 发送数据接口
        /// </summary>
        /// <param name="characteristic"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task Write(byte[] data)
        {
            if (CurrentWriteCharacteristic != null)
            {
                CurrentWriteCharacteristic.WriteValueAsync(CryptographicBuffer.CreateFromByteArray(data), GattWriteOption.WriteWithResponse);
            }

        }

        /// <summary>
        /// 设置通知特征对象。
        /// </summary>
        /// <returns></returns>
        public async Task GetCurrentNotifyCharacteristic()
        {
            string msg = "";
            Guid guid = new Guid(NotifyCharacteristicGuid);
            CurrentService.GetCharacteristicsForUuidAsync(guid).Completed = async (asyncInfo, asyncStatus) =>
            {
                if (asyncStatus == AsyncStatus.Completed)
                {
                    GattCharacteristicsResult result = asyncInfo.GetResults();
                    msg = "特征对象=" + result.Status +" "+ result.Characteristics.Count;
                    ValueChanged(MsgType.NotifyTxt, msg);
                    if (result.Characteristics.Count > 0)
                    {
                        CurrentNotifyCharacteristic = result.Characteristics[CHARACTERISTIC_INDEX];
                        CurrentNotifyCharacteristic.ProtectionLevel = GattProtectionLevel.Plain;
                        CurrentNotifyCharacteristic.ValueChanged += Characteristic_ValueChanged;
                        await EnableNotifications(CurrentNotifyCharacteristic);

                    }
                    else
                    {
                        msg = "没有发现特征对象,自动重试中";
                        ValueChanged(MsgType.NotifyTxt, msg);
                        await GetCurrentNotifyCharacteristic();
                    }
                }
            };
        }

        /// <summary>
        /// 设置特征对象为接收通知对象
        /// </summary>
        /// <param name="characteristic"></param>
        /// <returns></returns>
        public async Task EnableNotifications(GattCharacteristic characteristic)
        {
            try
            {
                characteristic.WriteClientCharacteristicConfigurationDescriptorAsync(CHARACTERISTIC_NOTIFICATION_TYPE).Completed = async (asyncInfo, asyncStatus) =>
                {
                    if (asyncStatus == AsyncStatus.Completed)
                    {
                        GattCommunicationStatus status = asyncInfo.GetResults();
                        string msg = "接收通知对象=" + status;
                        ValueChanged(MsgType.NotifyTxt, msg);

                        if(status == GattCommunicationStatus.Success)
                        {
                            msg = "" + status;
                            ValueChanged(MsgType.NotifyGattCommunication, msg);
                        }
                        else
                        {
                            msg = "FAILE";
                            ValueChanged(MsgType.NotifyGattCommunication, msg);
                        }
                    }
                };
            }
            catch(Exception e)
            {
                ValueChanged(MsgType.NotifyTxt, "exception happen");
            }  
        }

        private void Characteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
            byte[] data;
            CryptographicBuffer.CopyToByteArray(args.CharacteristicValue, out data);
            //string str = BitConverter.ToString(data);
            string str = System.Text.Encoding.Default.GetString(data);
            if(str.IndexOf("BLE CONNECTED") >= 0)
            {
                string msg = "Successed";
                ValueChanged(MsgType.NotifyGattCommunication, msg);
            }
            else if(str.IndexOf("BLE CONNECT TIMEOUT") >= 0)
            {
                string msg = "DISCONNECTED";
                ValueChanged(MsgType.NotifyGattCommunication, msg);
            }
            //ValueChanged(MsgType.BLEData, str, data);
            Receive(data.Length, data);

        }
        private static void Delay(int ms)
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(ms) > DateTime.Now)
            {
                Application.DoEvents();
            }
            return;
        }
    }

    public enum MsgType
    {
        NotifyTxt,
        NotifyConnectDevice,
        NotifyGattCharacteristics,
        NotifyGattCommunication,
        NotifyStates,
        BLEData
    }
}
