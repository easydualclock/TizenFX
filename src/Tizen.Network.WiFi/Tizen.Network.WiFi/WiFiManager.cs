/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tizen.Network.WiFi
{
    /// <summary>
    /// A manager class which allows applications to connect to a Wireless Local Area Network (WLAN) and to transfer data over the network.<br>
    /// The Wi-Fi Manager enables your application to activate and deactivate a local Wi-Fi device, and to connect to a WLAN network in the infrastructure mode.
    /// </summary>
    static public class WiFiManager
    {
        /// <summary>
        /// The local MAC address.
        /// </summary>
        /// <value>Represents the mac address of the WiFi.</value>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        static public string MacAddress
        {
            get
            {
                return WiFiManagerImpl.Instance.MacAddress;
            }
        }

        /// <summary>
        /// The name of the network interface.
        /// </summary>
        /// <value>Interface name of WiFi.</value>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        static public string InterfaceName
        {
            get
            {
                return WiFiManagerImpl.Instance.InterfaceName;
            }
        }

        /// <summary>
        /// The network connection state.
        /// </summary>
        /// <value>Represents the connection state of WiFi.</value>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        static public WiFiConnectionState ConnectionState
        {
            get
            {
                return WiFiManagerImpl.Instance.ConnectionState;
            }
        }

        /// <summary>
        /// A property to Check whether Wi-Fi is activated.
        /// </summary>
        /// <value>Boolean value to check whether WiFi is activated or not.</value>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        static public bool IsActive
        {
            get
            {
                return WiFiManagerImpl.Instance.IsActive;
            }
        }

        /// <summary>
        /// DeviceStateChanged is raised when the device state is changed.
        /// </summary>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        static public event EventHandler<DeviceStateChangedEventArgs> DeviceStateChanged
        {
            add
            {
                WiFiManagerImpl.Instance.DeviceStateChanged += value;
            }
            remove
            {
                WiFiManagerImpl.Instance.DeviceStateChanged -= value;
            }
        }

        /// <summary>
        /// ConnectionStateChanged is raised when the connection state is changed.
        /// </summary>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        static public event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged
        {
            add
            {
                WiFiManagerImpl.Instance.ConnectionStateChanged += value;
            }
            remove
            {
                WiFiManagerImpl.Instance.ConnectionStateChanged -= value;
            }
        }

        /// <summary>
        /// RssiLevelChanged is raised when the RSSI of connected Wi-Fi is changed.
        /// </summary>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        static public event EventHandler<RssiLevelChangedEventArgs> RssiLevelChanged
        {
            add
            {
                WiFiManagerImpl.Instance.RssiLevelChanged += value;
            }
            remove
            {
                WiFiManagerImpl.Instance.RssiLevelChanged -= value;
            }
        }

        /// <summary>
        /// BackgroundScanFinished is raised when the background scan is finished.
        /// The background scan starts automatically when wifi is activated. The callback will be invoked periodically.
        /// </summary>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        static public event EventHandler BackgroundScanFinished
        {
            add
            {
                WiFiManagerImpl.Instance.BackgroundScanFinished += value;
            }
            remove
            {
                WiFiManagerImpl.Instance.BackgroundScanFinished -= value;
            }
        }

        /// <summary>
        /// Gets the result of the scan.
        /// </summary>
        /// <returns> A list of WiFiAP objects.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public IEnumerable<WiFiAP> GetFoundAPs()
        {
            return WiFiManagerImpl.Instance.GetFoundAPs();
        }

        /// <summary>
        /// Gets the result of specific AP scan.
        /// </summary>
        /// <returns> A list contains the WiFiAP objects.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public IEnumerable<WiFiAP> GetFoundSpecificAPs()
        {
            return WiFiManagerImpl.Instance.GetFoundSpecificAPs();
        }

        /// <summary>
        /// Gets the list of wifi configurations.
        /// </summary>
        /// <returns>A list contains the WiFiConfiguration objects.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.profile</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="OutOfMemoryException">Thrown when system is out of memory.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public IEnumerable<WiFiConfiguration> GetWiFiConfigurations()
        {
            return WiFiManagerImpl.Instance.GetWiFiConfigurations();
        }

        /// <summary>
        /// Saves Wi-Fi configuration of access point.
        /// </summary>
        /// <param name="configuration">The configuration to be stored</param>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.profile</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentNullException">Thrown when WiFiConfiguration is passed as null.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public void SaveWiFiConfiguration(WiFiConfiguration configuration)
        {
            WiFiManagerImpl.Instance.SaveWiFiNetworkConfiguration(configuration);
        }

        /// <summary>
        /// Gets the object of the connected WiFiAP.
        /// </summary>
        /// <returns> The connected wifi access point(AP) information.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="OutOfMemoryException">Thrown when system is out of memory.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public WiFiAP GetConnectedAP()
        {
            return WiFiManagerImpl.Instance.GetConnectedAP();
        }

        /// <summary>
        /// Activates Wi-Fi asynchronously.
        /// </summary>
        /// <returns> A task indicating whether the Activate method is done or not.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.set</privilege>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public Task ActivateAsync()
        {
            return WiFiManagerImpl.Instance.ActivateAsync();
        }

        /// <summary>
        /// Activates Wi-Fi asynchronously and displays Wi-Fi picker (popup) when Wi-Fi is not automatically connected.
        /// </summary>
        /// <returns> A task indicating whether the ActivateWithPicker method is done or not.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.set</privilege>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public Task ActivateWithPickerAsync()
        {
            return WiFiManagerImpl.Instance.ActivateWithWiFiPickerTestedAsync();
        }

        /// <summary>
        /// Deactivates Wi-Fi asynchronously.
        /// </summary>
        /// <returns> A task indicating whether the Deactivate method is done or not.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.set</privilege>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public Task DeactivateAsync()
        {
            return WiFiManagerImpl.Instance.DeactivateAsync();
        }

        /// <summary>
        /// Starts scan asynchronously.
        /// </summary>
        /// <returns> A task indicating whether the Scan method is done or not.</returns>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.set</privilege>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public Task ScanAsync()
        {
            return WiFiManagerImpl.Instance.ScanAsync();
        }

        /// <summary>
        /// Starts specific access point scan, asynchronously.
        /// </summary>
        /// <returns> A task indicating whether the ScanSpecificAP method is done or not.</returns>
        /// <param name="essid">The essid of hidden ap</param>
        /// <feature>http://tizen.org/feature/network.wifi</feature>
        /// <privilege>http://tizen.org/privilege/network.set</privilege>
        /// <privilege>http://tizen.org/privilege/network.get</privilege>
        /// <exception cref="NotSupportedException">Thrown when WiFi is not supported.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when permission is denied.</exception>
        /// <exception cref="ArgumentException">Thrown when method is failed due to an invalid parameter.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the method failed due to invalid operation.</exception>
        static public Task ScanSpecificAPAsync(string essid)
        {
            return WiFiManagerImpl.Instance.ScanSpecificAPAsync(essid);
        }
    }
}
