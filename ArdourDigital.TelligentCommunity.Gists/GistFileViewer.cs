using System;
using Telligent.Evolution.Extensibility.Storage.Version1;
using Telligent.Evolution.Extensibility.UI.Version1;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.Gists
{
    public class GistFileViewer : IPlugin, IFileViewer
    {
        public int DefaultOrderNumber
        {
            get
            {
                return 100;
            }
        }

        public string Description
        {
            get
            {
                return "Embeds GitHub Gists using the Gist embed scripts";
            }
        }

        public string Name
        {
            get
            {
                return "Ardour Digital - GitHub Gist File Viewer";
            }
        }

        public string[] SupportedFileExtensions
        {
            get
            {
                return new string[0];
            }
        }

        public string SupportedUrlPattern
        {
            get
            {
                return "https://gist.github.com/[a-zA-Z0-9\-]+/[a-fA-F0-9]+";
            }
        }

        public FileViewerMediaType GetMediaType(Uri url, IFileViewerOptions options)
        {
            return FileViewerMediaType.Document;
        }

        public FileViewerMediaType GetMediaType(ICentralizedFile file, IFileViewerOptions options)
        {
            throw new FileViewerNotSupportedException();
        }

        public void Initialize()
        {
        }

        public string Render(Uri url, IFileViewerOptions options)
        {
            if (options.ViewType == FileViewerViewType.Preview)
            {
                return string.Format(@"<div>GitHub Gist Embed for <a href=""{0}""</a>Gist</a></div>", url);
            }

            return string.Format(@"<script src=""{0}.js""></script>", url);
        }

        public string Render(ICentralizedFile file, IFileViewerOptions options)
        {
            throw new FileViewerNotSupportedException();
        }
    }
}
