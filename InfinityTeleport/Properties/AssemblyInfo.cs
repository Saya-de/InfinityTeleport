using System.Reflection;
using MelonLoader;
using InfinityTeleport;

[assembly: AssemblyTitle(InfinityTeleport.BuildInfo.Description)]
[assembly: AssemblyDescription(InfinityTeleport.BuildInfo.Description)]
[assembly: AssemblyCompany(InfinityTeleport.BuildInfo.Company)]
[assembly: AssemblyProduct(InfinityTeleport.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + InfinityTeleport.BuildInfo.Author)]
[assembly: AssemblyTrademark(InfinityTeleport.BuildInfo.Company)]
[assembly: AssemblyVersion(InfinityTeleport.BuildInfo.Version)]
[assembly: AssemblyFileVersion(InfinityTeleport.BuildInfo.Version)]
[assembly: MelonInfo(typeof(InfinityTeleport.InfinityTeleport), InfinityTeleport.BuildInfo.Name, InfinityTeleport.BuildInfo.Version, InfinityTeleport.BuildInfo.Author, InfinityTeleport.BuildInfo.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.DarkGray)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]