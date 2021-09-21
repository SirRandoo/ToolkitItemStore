using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitCore.Models;

namespace ToolkitItemStore
{
    public class ToolkitItemStorePermissions : PermissionsWrapper
    {
        public override List<Permission> Permissions { get { return permissions; } }

        public override string Namespace { get { return "toolkititemstore"; } }

        List<Permission> permissions = DefaultPermissions();

        static List<Permission> DefaultPermissions()
        {
            return new List<Permission>();
        }
    }
}
