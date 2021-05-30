using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CarDontAdded = "Araç eklenemedi";
        public static string MaintenanceTime = "Bakım çalışması";
        public static string CarListed = "Araçlar listelendi";
        public static string RentalAdded = "Added";
        public static string RentalDeleted = "Deleted";
        public static string RentalFailures = "Fails";
        public static string Success = "Succeed";
        public static string CarImageAdded = "Araba görseli eklendi";
        public static string CarImageLimitExceeded = "Daha fazla görüntü ekleyemezsiniz";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
