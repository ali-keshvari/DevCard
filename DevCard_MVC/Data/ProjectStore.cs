using DevCard_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace DevCard_MVC.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects() {
            return new List<Project>
            {
                new Project(0, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg", "Atriya"),
                new Project(1, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg", "ZoodFood"),
                new Project(2, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg", "MONOP"),
                new Project(3, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "project-4.jpg", "NASA"),
            };
        }
        public static Project GetProjectBy(long id) {
            return GetProjects().FirstOrDefault(x=> x.Id == id);
        }
        
    }
}
