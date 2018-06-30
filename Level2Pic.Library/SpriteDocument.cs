// <copyright file="SpriteDocument.cs" company="NZoid154's Softwares">
// Copyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Net.NetworkInformation;
    using System.Xml;

    /// <summary>
    /// Represents a document that contains the list of necessary sprites for Super Mario Flash
    /// </summary>
    public class SpriteDocument
    {
        /// <summary>
        /// The document currently being worked with.
        /// </summary>
        private XmlDocument document;

        /// <summary>
        /// Initializes a new instance of the SpriteDocument class.
        /// </summary>
        public SpriteDocument()
        {
            this.document = new XmlDocument();
            this.Backgrounds = new SpriteCollection();
            this.Labels = new SpriteCollection();
            this.Sprites = new SpriteCollection();
        }

        /// <summary>
        /// Initializes a new instance of the SpriteDocument class with parameters.
        /// </summary>
        /// <param name="backgrounds">A collection that contains all the necessary backgrounds in Super Mario Flash.</param>
        /// <param name="sprites">A collection that contains all the necessary sprites (tiles and enemies) in Super Mario Flash.</param>
        /// <param name="labels">A collection that contains all the necessary labels for Super Mario Flash.</param>
        public SpriteDocument(SpriteCollection backgrounds, SpriteCollection sprites, SpriteCollection labels)
        {
            this.Backgrounds = backgrounds;
            this.Labels = labels;
            this.Sprites = sprites;
        }

        /// <summary>
        /// Gets or sets the list of available backgrounds in Super Mario Flash.
        /// </summary>
        public SpriteCollection Backgrounds
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of available labels in Super Mario Flash.
        /// </summary>
        public SpriteCollection Labels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of available sprites (tiles or enemies) in Super Mario Flash.
        /// </summary>
        public SpriteCollection Sprites
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the warnings that had occured while attempting to validate the document.
        /// </summary>
        public string[] Warnings
        {
            get;
            private set;
        }

        /// <summary>
        /// Load a sprite document.
        /// </summary>
        /// <param name="file">The path to the existing file.</param>
        public void Load(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("The file could not be found.", file);
            }

            this.document.Load(file);
            this.Load();
        }

        /// <summary>
        /// Saves the sprite document.
        /// </summary>
        /// <param name="file">The path to save the file.</param>
        public void Save(string file)
        {
            XmlDocument newSpriteDoc = new XmlDocument();

            // Header
            XmlNode declaration = newSpriteDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            newSpriteDoc.AppendChild(declaration);

            // SpriteDocument
            XmlNode spriteDoc = newSpriteDoc.CreateElement("SpriteDocument");

            // Backgrounds
            XmlNode backgroundParent = newSpriteDoc.CreateElement("Backgrounds");
            foreach (KeyValuePair<int, Sprite> background in this.Backgrounds)
            {
                // XmlElement - Sprite
                XmlElement sprite = newSpriteDoc.CreateElement("Sprite");
                sprite.InnerText = background.Value.Description;

                // XmlAttribute - ID
                XmlAttribute id = newSpriteDoc.CreateAttribute("ID");
                id.Value = background.Key.ToString();
                sprite.Attributes.Append(id);

                // XmlAttribute - Location
                XmlAttribute location = newSpriteDoc.CreateAttribute("Location");
                location.Value = string.Format("{0}, {1}", background.Value.Location.X, background.Value.Location.Y);
                sprite.Attributes.Append(location);

                // XmlAttribute - Name
                XmlAttribute name = newSpriteDoc.CreateAttribute("Name");
                name.Value = background.Value.Name;
                sprite.Attributes.Append(name);

                // XmlAttribute - Path
                XmlAttribute path = newSpriteDoc.CreateAttribute("Path");
                path.Value = background.Value.ImagePath;
                sprite.Attributes.Append(path);

                // XmlAttribute - RotateFlip
                XmlAttribute rotateFlip = newSpriteDoc.CreateAttribute("RotateFlip");
                rotateFlip.Value = background.Value.RotateFlip.ToString();
                sprite.Attributes.Append(rotateFlip);

                // XmlAttribute - Size
                XmlAttribute size = newSpriteDoc.CreateAttribute("Size");
                size.Value = string.Format("{0}, {1}", background.Value.Size.Width, background.Value.Size.Height);
                sprite.Attributes.Append(size);

                backgroundParent.AppendChild(sprite);
            }

            // Labels
            XmlNode labelParent = newSpriteDoc.CreateElement("Labels");
            foreach (KeyValuePair<int, Sprite> label in this.Labels)
            {
                // XmlElement - Sprite
                XmlElement sprite = newSpriteDoc.CreateElement("Sprite");
                sprite.InnerText = label.Value.Description;

                // XmlAttribute - ID
                XmlAttribute id = newSpriteDoc.CreateAttribute("ID");
                id.Value = label.Key.ToString();
                sprite.Attributes.Append(id);

                // XmlAttribute - Location
                XmlAttribute location = newSpriteDoc.CreateAttribute("Location");
                location.Value = string.Format("{0}, {1}", label.Value.Location.X, label.Value.Location.Y);
                sprite.Attributes.Append(location);

                // XmlAttribute - Name
                XmlAttribute name = newSpriteDoc.CreateAttribute("Name");
                name.Value = label.Value.Name;
                sprite.Attributes.Append(name);

                // XmlAttribute - Path
                XmlAttribute path = newSpriteDoc.CreateAttribute("Path");
                path.Value = label.Value.ImagePath;
                sprite.Attributes.Append(path);

                // XmlAttribute - RotateFlip
                XmlAttribute rotateFlip = newSpriteDoc.CreateAttribute("RotateFlip");
                rotateFlip.Value = label.Value.RotateFlip.ToString();
                sprite.Attributes.Append(rotateFlip);

                // XmlAttribute - Size
                XmlAttribute size = newSpriteDoc.CreateAttribute("Size");
                size.Value = string.Format("{0}, {1}", label.Value.Size.Width, label.Value.Size.Height);
                sprite.Attributes.Append(size);

                labelParent.AppendChild(sprite);
            }

            // Sprites
            XmlNode spriteParent = newSpriteDoc.CreateElement("Sprites");
            foreach (KeyValuePair<int, Sprite> sprite in this.Sprites)
            {
                // XmlElement - Sprite
                XmlElement spriteNode = newSpriteDoc.CreateElement("Sprite");
                spriteNode.InnerText = sprite.Value.Description;

                // XmlAttribute - ID
                XmlAttribute id = newSpriteDoc.CreateAttribute("ID");
                id.Value = sprite.Key.ToString();
                spriteNode.Attributes.Append(id);

                // XmlAttribute - Location
                XmlAttribute location = newSpriteDoc.CreateAttribute("Location");
                location.Value = string.Format("{0}, {1}", sprite.Value.Location.X, sprite.Value.Location.Y);
                spriteNode.Attributes.Append(location);

                // XmlAttribute - Name
                XmlAttribute name = newSpriteDoc.CreateAttribute("Name");
                name.Value = sprite.Value.Name;
                spriteNode.Attributes.Append(name);

                // XmlAttribute - Path
                XmlAttribute path = newSpriteDoc.CreateAttribute("Path");
                path.Value = sprite.Value.ImagePath;
                spriteNode.Attributes.Append(path);

                // XmlAttribute - RotateFlip
                XmlAttribute rotateFlip = newSpriteDoc.CreateAttribute("RotateFlip");
                rotateFlip.Value = sprite.Value.RotateFlip.ToString();
                spriteNode.Attributes.Append(rotateFlip);

                // XmlAttribute - Size
                XmlAttribute size = newSpriteDoc.CreateAttribute("Size");
                size.Value = string.Format("{0}, {1}", sprite.Value.Size.Width, sprite.Value.Size.Height);
                spriteNode.Attributes.Append(size);

                spriteParent.AppendChild(spriteNode);
            }

            // Append it to the root node
            spriteDoc.AppendChild(backgroundParent);
            spriteDoc.AppendChild(labelParent);
            spriteDoc.AppendChild(spriteParent);
            newSpriteDoc.AppendChild(spriteDoc);

            // Save it to a file.
            newSpriteDoc.Save(file);
        }

        /// <summary>
        /// Validates the document against the schema. This ensures every node required is available.
        /// </summary>
        public void Validate()
        {
            List<string> warnings = new List<string>();

            this.document.Schemas.Add(null, "http://nzoid154.comoj.com/schemas/GraphicsSchema.xsd");
            this.document.Validate(delegate(object sender, System.Xml.Schema.ValidationEventArgs e)
            {
                switch (e.Severity)
                {
                    case System.Xml.Schema.XmlSeverityType.Error:
                        throw new XmlException("Document failed schema validation. Check the inner exception for more details.", e.Exception);
                    case System.Xml.Schema.XmlSeverityType.Warning:
                        warnings.Add(e.Message);
                        break;
                }
            });

            this.Warnings = warnings.ToArray();
        }

        /// <summary>
        /// Loads the document into a SpriteDocument class.
        /// </summary>
        private void Load()
        {
            // Loop through each available sprites and add them to the correct groups accordingly.
            foreach (XmlNode sprites in this.document.SelectNodes("//Sprite"))
            {
                string[] location = sprites.Attributes["Location"].Value.Split(',');
                string[] size = sprites.Attributes["Size"].Value.Split(',');
                Sprite sprite = new Sprite()
                {
                    Description = sprites.InnerText,
                    ImagePath = sprites.Attributes["Path"].Value,
                    Location = new Point(int.Parse(location[0]), int.Parse(location[1])),
                    Name = sprites.Attributes["Name"].Value,
                    RotateFlip = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), sprites.Attributes["RotateFlip"].Value),
                    Size = new Size(int.Parse(size[0]), int.Parse(size[1]))
                };

                // Add it to the correct collection according to the parent node
                switch (sprites.ParentNode.Name)
                {
                    case "Backgrounds":
                        this.Backgrounds.Add(int.Parse(sprites.Attributes["ID"].Value), sprite);
                        break;
                    case "Labels":
                        this.Labels.Add(int.Parse(sprites.Attributes["ID"].Value), sprite);
                        break;
                    case "Sprites":
                        this.Sprites.Add(int.Parse(sprites.Attributes["ID"].Value), sprite);
                        break;
                    default:
                        throw new XmlException("The parent node is invalid.");
                }
            }
        }
    }
}
