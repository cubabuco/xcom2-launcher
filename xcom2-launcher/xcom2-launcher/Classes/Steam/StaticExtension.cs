using Steamworks;

namespace XCOM2Launcher.Steam
{
    public static class StaticExtension
    {
        public static PublishedFileId_t ToPublishedFileID(this ulong id) => new PublishedFileId_t(id);
    }
}