using System;
using System.Xml.Linq;

namespace Level2Pic.Classes
{
    /// <summary>
    /// Represents a Dapper XML file that is use to get information about levels in Pouetpu-Games
    /// </summary>
    public class Dapper
    {
        /// <summary>
        /// The document to get information
        /// </summary>
        XDocument dapperDoc;

        /// <summary>
        /// Initializes a new instance of the Dapper class
        /// </summary>
        /// <param name="xml">The XML string to read and gather level information</param>
        public Dapper(string xml)
        {
            this.dapperDoc = XDocument.Parse(xml);
        }

        /// <summary>
        /// Gets the author who made the level
        /// </summary>
        public string Author
        {
            get
            {
                return this.dapperDoc.Element("elements").Element("General").Element("Author").Value;
            }
        }

        /// <summary>
        /// Gets the link to the author's profile
        /// </summary>
        public Uri AuthorUri
        {
            get
            {
                return new Uri(this.dapperDoc.Element("elements").Element("General").Element("Author").Attribute("href").Value, UriKind.RelativeOrAbsolute);
            }
        }

        /// <summary>
        /// Gets the level code published into Pouetpu-Games
        /// </summary>
        public string Code
        {
            get
            {
                return this.dapperDoc.Element("elements").Element("General").Element("Code").Value;
            }
        }

        /// <summary>
        /// Gets the description the author have said about the level
        /// </summary>
        public string Description
        {
            get
            {
                return this.dapperDoc.Element("elements").Element("General").Element("Description").Value;
            }
        }

        /// <summary>
        /// Gets the status of the download
        /// </summary>
        public string DownloadStatus
        {
            get
            {
                return this.dapperDoc.Element("elements").Element("dapper").Element("status").Value;
            }
        }

        /// <summary>
        /// Gets the error that had occured while attempting to get the level
        /// </summary>
        public Exception Error
        {
            get
            {
                // Is there an error?
                if (this.dapperDoc.Element("elements").Element("dapper").Element("description") == null)
                {
                    return null;
                }
                else
                {
                    return new Exception(this.dapperDoc.Element("elements").Element("dapper").Element("description").Value);
                }
            }
        }

        /// <summary>
        /// Gets the online name the user have published for the level
        /// </summary>
        public string Name
        {
            get
            {
                return this.dapperDoc.Element("elements").Element("General").Element("Name").Value;
            }
        }

        /// <summary>
        /// Get the date when the author published the level
        /// </summary>
        public DateTime Published
        {
            get
            {
                // Split the date since pouetpu uses a different date format
                string[] date = this.dapperDoc.Element("elements").Element("Community").Element("Published").Value.Split('/');
                return new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            }
        }

        /// <summary>
        /// Gets the average rating the level have received
        /// </summary>
        public float Ratings
        {
            get
            {
                return float.Parse("0." + this.dapperDoc.Element("elements").Element("Community").Element("Ratings").Value);
            }
        }

        /// <summary>
        /// Gets the status of the level
        /// </summary>
        public string Status
        {
            get
            {
                // Determine what is the status of the level based on the image's source
                switch (this.dapperDoc.Element("elements").Element("Community").Element("Status").Attribute("src").Value)
                {
                    case "http://www.pouetpu-games.net/images/section_1.png":
                        return "The Pending Levels";
                    case "http://www.pouetpu-games.net/images/section_2.png":
                        return "The Best Levels";
                    case "http://www.pouetpu-games.net/images/section_3.png":
                        return "The Good Levels";
                    case "http://www.pouetpu-games.net/images/section_4.png":
                        return "The Spam Levels";
                    default:
                        return "The Unknown Levels";
                }
            }
        }

        /// <summary>
        /// Gets the URI of the level loaded in Pouetpu-Games
        /// </summary>
        public Uri Uri
        {
            get
            {
                return new Uri(this.dapperDoc.Element("elements").Element("dapper").Element("applyToUrl").Value, UriKind.RelativeOrAbsolute);
            }
        }

        /// <summary>
        /// Get the number of views the level have attracted
        /// </summary>
        public int Views
        {
            get
            {
                return int.Parse(this.dapperDoc.Element("elements").Element("Community").Element("Views").Value);
            }
        }

        /// <summary>
        /// Gets the numbr of rates/votes the level have received
        /// </summary>
        public int Votes
        {
            get
            {
                return int.Parse(this.dapperDoc.Element("elements").Element("Community").Element("Votes").Value);
            }
        }
    }
}
