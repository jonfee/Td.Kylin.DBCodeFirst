

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 终端设备类型
    /// </summary>
    public enum TerminalDevice
    {
        /// <summary>
        /// IOS
        /// </summary>
        [Description("IOS")]
        IOS = 1,
        /// <summary>
        /// Android
        /// </summary>
        [Description("Android")]
        Android = 2,
        /// <summary>
        /// WinPhone
        /// </summary>
        [Description("WinPhone")]
        WindowsPhone = 4
    }
}
