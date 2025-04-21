using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IMobileDeviceRepository
    {
        IEnumerable<MobileDevice> GetAllMobileDevice();
        MobileDevice GetMobileDeviceByUserId(long userid);
        void AddMobileDevice(MobileDevice registration);
        void UpdateMobileDevice(MobileDevice registration);
        void DeleteMobileDevice(long userid);
    }
}
