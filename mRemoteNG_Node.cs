namespace mRemoteNG_PuttyImporter
{
    using System;
    using System.Xml.Serialization;

    [XmlRoot("Node")]
    public class Node
    {
        [XmlAttribute("Name")]
        public string Name { get; set; } = "New Connection";

        [XmlAttribute("Type")]
        public string Type { get; set; } = "Connection";

        [XmlAttribute("Descr")]
        public string Descr { get; set; } = "";

        [XmlAttribute("Icon")]
        public string Icon { get; set; } = "mRemoteNG";

        [XmlAttribute("Panel")]
        public string Panel { get; set; } = "General";

        [XmlAttribute("Id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [XmlAttribute("Username")]
        public string Username { get; set; } = "not set";

        [XmlAttribute("Domain")]
        public string Domain { get; set; } = "";

        [XmlAttribute("Password")]
        public string Password { get; set; } = "";

        [XmlAttribute("Hostname")]
        public string Hostname { get; set; } = "not set";

        [XmlAttribute("Protocol")]
        public string Protocol { get; set; } = "SSH2";

        [XmlAttribute("PuttySession")]
        public string PuttySession { get; set; } = "Default Settings";

        [XmlAttribute("Port")]
        public string Port { get; set; } = "22";

        [XmlAttribute("ConnectToConsole")]
        public string ConnectToConsole { get; set; } = "false";

        [XmlAttribute("UseCredSsp")]
        public string UseCredSsp { get; set; } = "true";

        [XmlAttribute("RenderingEngine")]
        public string RenderingEngine { get; set; } = "IE";

        [XmlAttribute("ICAEncryptionStrength")]
        public string ICAEncryptionStrength { get; set; } = "EncrBasic";

        [XmlAttribute("RDPAuthenticationLevel")]
        public string RDPAuthenticationLevel { get; set; } = "NoAuth";

        [XmlAttribute("RDPMinutesToIdleTimeout")]
        public string RDPMinutesToIdleTimeout { get; set; } = "0";

        [XmlAttribute("RDPAlertIdleTimeout")]
        public string RDPAlertIdleTimeout { get; set; } = "false";

        [XmlAttribute("LoadBalanceInfo")]
        public string LoadBalanceInfo { get; set; } = "";

        [XmlAttribute("Colors")]
        public string Colors { get; set; } = "Colors16Bit";

        [XmlAttribute("Resolution")]
        public string Resolution { get; set; } = "FitToWindow";

        [XmlAttribute("AutomaticResize")]
        public string AutomaticResize { get; set; } = "true";

        [XmlAttribute("DisplayWallpaper")]
        public string DisplayWallpaper { get; set; } = "false";

        [XmlAttribute("DisplayThemes")]
        public string DisplayThemes { get; set; } = "false";

        [XmlAttribute("EnableFontSmoothing")]
        public string EnableFontSmoothing { get; set; } = "false";

        [XmlAttribute("EnableDesktopComposition")]
        public string EnableDesktopComposition { get; set; } = "false";

        [XmlAttribute("CacheBitmaps")]
        public string CacheBitmaps { get; set; } = "false";

        [XmlAttribute("RedirectDiskDrives")]
        public string RedirectDiskDrives { get; set; } = "false";

        [XmlAttribute("RedirectPorts")]
        public string RedirectPorts { get; set; } = "false";

        [XmlAttribute("RedirectPrinters")]
        public string RedirectPrinters { get; set; } = "false";

        [XmlAttribute("RedirectSmartCards")]
        public string RedirectSmartCards { get; set; } = "false";

        [XmlAttribute("RedirectSound")]
        public string RedirectSound { get; set; } = "DoNotPlay";

        [XmlAttribute("SoundQuality")]
        public string SoundQuality { get; set; } = "Dynamic";

        [XmlAttribute("RedirectKeys")]
        public string RedirectKeys { get; set; } = "false";

        [XmlAttribute("Connected")]
        public string Connected { get; set; } = "false";

        [XmlAttribute("PreExtApp")]
        public string PreExtApp { get; set; } = "";

        [XmlAttribute("PostExtApp")]
        public string PostExtApp { get; set; } = "";

        [XmlAttribute("MacAddress")]
        public string MacAddress { get; set; } = "";

        [XmlAttribute("UserField")]
        public string UserField { get; set; } = "";

        [XmlAttribute("ExtApp")]
        public string ExtApp { get; set; } = "";

        [XmlAttribute("VNCCompression")]
        public string VNCCompression { get; set; } = "CompNone";

        [XmlAttribute("VNCEncoding")]
        public string VNCEncoding { get; set; } = "EncHextile";

        [XmlAttribute("VNCAuthMode")]
        public string VNCAuthMode { get; set; } = "AuthVNC";

        [XmlAttribute("VNCProxyType")]
        public string VNCProxyType { get; set; } = "ProxyNone";

        [XmlAttribute("VNCProxyIP")]
        public string VNCProxyIP { get; set; } = "";

        [XmlAttribute("VNCProxyPort")]
        public string VNCProxyPort { get; set; } = "0";

        [XmlAttribute("VNCProxyUsername")]
        public string VNCProxyUsername { get; set; } = "";

        [XmlAttribute("VNCProxyPassword")]
        public string VNCProxyPassword { get; set; } = "";

        [XmlAttribute("VNCColors")]
        public string VNCColors { get; set; } = "ColNormal";

        [XmlAttribute("VNCSmartSizeMode")]
        public string VNCSmartSizeMode { get; set; } = "SmartSAspect";

        [XmlAttribute("VNCViewOnly")]
        public string VNCViewOnly { get; set; } = "false";

        [XmlAttribute("RDGatewayUsageMethod")]
        public string RDGatewayUsageMethod { get; set; } = "Never";

        [XmlAttribute("RDGatewayHostname")]
        public string RDGatewayHostname { get; set; } = "";

        [XmlAttribute("RDGatewayUseConnectionCredentials")]
        public string RDGatewayUseConnectionCredentials { get; set; } = "Yes";

        [XmlAttribute("RDGatewayUsername")]
        public string RDGatewayUsername { get; set; } = "";

        [XmlAttribute("RDGatewayPassword")]
        public string RDGatewayPassword { get; set; } = "";

        [XmlAttribute("RDGatewayDomain")]
        public string RDGatewayDomain { get; set; } = "";

        [XmlAttribute("InheritCacheBitmaps")]
        public string InheritCacheBitmaps { get; set; } = "false";

        [XmlAttribute("InheritColors")]
        public string InheritColors { get; set; } = "false";

        [XmlAttribute("InheritDescription")]
        public string InheritDescription { get; set; } = "false";

        [XmlAttribute("InheritDisplayThemes")]
        public string InheritDisplayThemes { get; set; } = "false";

        [XmlAttribute("InheritDisplayWallpaper")]
        public string InheritDisplayWallpaper { get; set; } = "false";

        [XmlAttribute("InheritEnableFontSmoothing")]
        public string InheritEnableFontSmoothing { get; set; } = "false";

        [XmlAttribute("InheritEnableDesktopComposition")]
        public string InheritEnableDesktopComposition { get; set; } = "false";

        [XmlAttribute("InheritDomain")]
        public string InheritDomain { get; set; } = "false";

        [XmlAttribute("InheritIcon")]
        public string InheritIcon { get; set; } = "false";

        [XmlAttribute("InheritPanel")]
        public string InheritPanel { get; set; } = "false";

        [XmlAttribute("InheritPassword")]
        public string InheritPassword { get; set; } = "false";

        [XmlAttribute("InheritPort")]
        public string InheritPort { get; set; } = "false";

        [XmlAttribute("InheritProtocol")]
        public string InheritProtocol { get; set; } = "false";

        [XmlAttribute("InheritPuttySession")]
        public string InheritPuttySession { get; set; } = "false";

        [XmlAttribute("InheritRedirectDiskDrives")]
        public string InheritRedirectDiskDrives { get; set; } = "false";

        [XmlAttribute("InheritRedirectKeys")]
        public string InheritRedirectKeys { get; set; } = "false";

        [XmlAttribute("InheritRedirectPorts")]
        public string InheritRedirectPorts { get; set; } = "false";

        [XmlAttribute("InheritRedirectPrinters")]
        public string InheritRedirectPrinters { get; set; } = "false";

        [XmlAttribute("InheritRedirectSmartCards")]
        public string InheritRedirectSmartCards { get; set; } = "false";

        [XmlAttribute("InheritRedirectSound")]
        public string InheritRedirectSound { get; set; } = "false";

        [XmlAttribute("InheritSoundQuality")]
        public string InheritSoundQuality { get; set; } = "false";

        [XmlAttribute("InheritResolution")]
        public string InheritResolution { get; set; } = "false";

        [XmlAttribute("InheritAutomaticResize")]
        public string InheritAutomaticResize { get; set; } = "false";

        [XmlAttribute("InheritUseConsoleSession")]
        public string InheritUseConsoleSession { get; set; } = "false";

        [XmlAttribute("InheritUseCredSsp")]
        public string InheritUseCredSsp { get; set; } = "false";

        [XmlAttribute("InheritRenderingEngine")]
        public string InheritRenderingEngine { get; set; } = "false";

        [XmlAttribute("InheritUsername")]
        public string InheritUsername { get; set; } = "false";

        [XmlAttribute("InheritICAEncryptionStrength")]
        public string InheritICAEncryptionStrength { get; set; } = "false";

        [XmlAttribute("InheritRDPAuthenticationLevel")]
        public string InheritRDPAuthenticationLevel { get; set; } = "false";

        [XmlAttribute("InheritRDPMinutesToIdleTimeout")]
        public string InheritRDPMinutesToIdleTimeout { get; set; } = "false";

        [XmlAttribute("InheritRDPAlertIdleTimeout")]
        public string InheritRDPAlertIdleTimeout { get; set; } = "false";

        [XmlAttribute("InheritLoadBalanceInfo")]
        public string InheritLoadBalanceInfo { get; set; } = "false";

        [XmlAttribute("InheritPreExtApp")]
        public string InheritPreExtApp { get; set; } = "false";

        [XmlAttribute("InheritPostExtApp")]
        public string InheritPostExtApp { get; set; } = "false";

        [XmlAttribute("InheritMacAddress")]
        public string InheritMacAddress { get; set; } = "false";

        [XmlAttribute("InheritUserField")]
        public string InheritUserField { get; set; } = "false";

        [XmlAttribute("InheritExtApp")]
        public string InheritExtApp { get; set; } = "false";

        [XmlAttribute("InheritVNCCompression")]
        public string InheritVNCCompression { get; set; } = "false";

        [XmlAttribute("InheritVNCEncoding")]
        public string InheritVNCEncoding { get; set; } = "false";

        [XmlAttribute("InheritVNCAuthMode")]
        public string InheritVNCAuthMode { get; set; } = "false";

        [XmlAttribute("InheritVNCProxyType")]
        public string InheritVNCProxyType { get; set; } = "false";

        [XmlAttribute("InheritVNCProxyIP")]
        public string InheritVNCProxyIP { get; set; } = "false";

        [XmlAttribute("InheritVNCProxyPort")]
        public string InheritVNCProxyPort { get; set; } = "false";

        [XmlAttribute("InheritVNCProxyUsername")]
        public string InheritVNCProxyUsername { get; set; } = "false";

        [XmlAttribute("InheritVNCProxyPassword")]
        public string InheritVNCProxyPassword { get; set; } = "false";

        [XmlAttribute("InheritVNCColors")]
        public string InheritVNCColors { get; set; } = "false";

        [XmlAttribute("InheritVNCSmartSizeMode")]
        public string InheritVNCSmartSizeMode { get; set; } = "false";

        [XmlAttribute("InheritVNCViewOnly")]
        public string InheritVNCViewOnly { get; set; } = "false";

        [XmlAttribute("InheritRDGatewayUsageMethod")]
        public string InheritRDGatewayUsageMethod { get; set; } = "false";

        [XmlAttribute("InheritRDGatewayHostname")]
        public string InheritRDGatewayHostname { get; set; } = "false";

        [XmlAttribute("InheritRDGatewayUseConnectionCredentials")]
        public string InheritRDGatewayUseConnectionCredentials { get; set; } = "false";

        [XmlAttribute("InheritRDGatewayUsername")]
        public string InheritRDGatewayUsername { get; set; } = "false";

        [XmlAttribute("InheritRDGatewayPassword")]
        public string InheritRDGatewayPassword { get; set; } = "false";

        [XmlAttribute("InheritRDGatewayDomain")]
        public string InheritRDGatewayDomain { get; set; } = "false";
    }

}
