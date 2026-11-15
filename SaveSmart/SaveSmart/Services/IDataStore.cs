using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TPLinkSmartDevices;
using TPLinkSmartDevices.Devices;

namespace SaveSmart.Services
{
	public interface IDataStore<T>
	{
		Task<bool> AddDeviceAsync(T device);
		Task<bool> UpdateDeviceAsync(T device);
		Task<bool> DeleteDeviceAsync(string id);
		Task<T> GetDeviceAsync(string id);
		Task<IEnumerable<T>> GetDevicesAsync(bool forceRefresh = false);
		//Task<List<TPLinkSmartDevice>> DiscoverDeviceAsync();

	}
}
