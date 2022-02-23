using MelonLoader;
using UnityEngine;


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

                VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = new Vector3(0, -500, 0);
            }

        }
        
    }
 
}
