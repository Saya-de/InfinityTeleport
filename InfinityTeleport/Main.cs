using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEditor;
using UnityEngine;
using System.Reflection;
using System.Text.RegularExpressions;
using UnhollowerRuntimeLib.XrefScans;
using VRC.Animation;
using VRC.Core;
using VRC.SDKBase;


namespace InfinityTeleport
{
    public static class BuildInfo
    {
        public const string Name = "InfinityTeleport";
        public const string Description = "Teleport to Infinity"; 
        public const string Author = "Saya"; 
        public const string Company = null;
        public const string Version = "1.8.7"; 
        public const string DownloadLink = null;

    }
    public class InfinityTeleport : MelonMod
    {
      
        public override void OnUpdate()
        {

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.I))
            {
                VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = new Vector3(9999999, 9999999, 9999999);
            }


            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F8))
            {               
                R.Respawn();
            }
        }
        
    }
    public static class R
    {
        private static bool XRefScanFor(this MethodBase methodBase, string searchTerm)
        {
            return XrefScanner.XrefScan(methodBase).Any(
                xref => xref.Type == XrefType.Global && xref.ReadAsObject()?.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private static RespawnDelegate GetRespawnDelegate
        {
            get
            {
                if (respawnDelegate != null) return respawnDelegate;
                MethodInfo respawnMethod = typeof(VRCPlayer).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Single(m => m.GetParameters().Length == 0 && m.ReturnType == typeof(void) && m.XRefScanFor("Respawned while not in a room."));

                respawnDelegate = (RespawnDelegate)Delegate.CreateDelegate(typeof(RespawnDelegate),VRCPlayer.field_Internal_Static_VRCPlayer_0,respawnMethod);
                return respawnDelegate;
            }
        }

        private static RespawnDelegate respawnDelegate;
        private delegate void RespawnDelegate();

        public static void Respawn()
        {
            GetRespawnDelegate();
            VRCPlayer.field_Internal_Static_VRCPlayer_0.GetComponent<VRCMotionState>().Reset();
        }

    }
}
