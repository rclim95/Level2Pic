// <copyright file="Zone.cs" company="NZoid154 Software">
// Copyright (c) 2010
// </copyright>

namespace Level2Pic.Library
{
    using System;

    /// <summary>
    /// Constants that defines the background to display on a Super Mario Flash Zone.
    /// </summary>
    public enum Backgrounds
    {
        /// <summary>
        /// The background of the zone have clouds (Super Mario All-Stars: Super Mario Bros. Overworld)
        /// </summary>
        Clouds = 1,

        /// <summary>
        /// The background of the zone is a cavern (Super Mario All-Stars: Super Mario Bros. Undergrounds)
        /// </summary>
        Cave = 2,

        /// <summary>
        /// The background of the zone is a forest (Super Mario World - Forest Levels)
        /// </summary>
        Forest = 3,

        /// <summary>
        /// The background of the zone is a castle (Super Mario World - Castle Levels)
        /// </summary>
        Castle = 4,

        /// <summary>
        /// The background of the zone have stars (Super Mario All-Stars: Super Mario Bros. Snowy Night Levels)
        /// </summary>
        Twilight = 5,

        /// <summary>
        /// The background of the zone is a ghost house (Super Mario World - Ghost House Levels)
        /// </summary>
        Ghost = 6
    }

    /// <summary>
    /// Constants that defines the music to play in the background on a Super Mario Flash Zone.
    /// </summary>
    public enum Musics
    {
        /// <summary>
        /// No music should be played
        /// </summary>
        None          = 0,

        /// <summary>
        /// Play &quot;Super Mario Bros. Overworld&quot; as the background music
        /// </summary>
        Overworld_SMB = 1,

        /// <summary>
        /// Play &quot;Super Mario World Overworld&quot; as the background music
        /// </summary>
        Overworld_SMW = 2,

        /// <summary>
        /// Play &quot;Super Mario Bros. 3 Athletics&quot; as the background music
        /// </summary>
        Athletics     = 3,

        /// <summary>
        /// Play &quot;Super Mario Bros. 3 World 1 Map&quot; as the background music
        /// </summary>
        Map_SMB       = 4,

        /// <summary>
        /// Play &quot;Super Mario Bros. Underground&quot; as the background music
        /// </summary>
        Underground   = 5,

        /// <summary>
        /// Play &quot;Super Mario World Castle&quot; as the background music
        /// </summary>
        Castle        = 6,

        /// <summary>
        /// Play &quot;Super Mario Bros. Final Boss Battle&quot; as the background music
        /// </summary>
        Boss          = 7,

        /// <summary>
        /// Play &quot;Super Mario World Map&quot; as the background music
        /// </summary>
        Map_SMW       = 8,

        /// <summary>
        /// Play &quot;Super Mario Bros. Starman Theme&quot; as the background music
        /// </summary>
        Starman       = 9,

        /// <summary>
        /// Play &quot;Super Mario Bros. Course Cleared&quot; as the background music
        /// </summary>
        End           = 10,

        /// <summary>
        /// Play &quot;Super Mario Bros. Castle Finish Theme&quot; as the background music
        /// </summary>
        Castle_End    = 11
    }

    /// <summary>
    /// Constants that consists of the default zone types available in Super Mario Flash
    /// </summary>
    public enum Zones
    {
        /// <summary>
        /// The Main Zone
        /// </summary>
        Main  = 2700,

        /// <summary>
        /// The Bonus Room
        /// </summary>
        Bonus = 5406
    }

    /// <summary>
    /// Provides access to properties for a level zone in Super Mario Flash
    /// </summary>
    public class Zone
    {
        /// <summary>
        /// The length of the zone. It must be greater than 0.
        /// </summary>
        private int zoneLength = 0;

        /// <summary>
        /// Initializes a new instance of the Zone class
        /// </summary>
        public Zone()
        {
            this.Background = Backgrounds.Castle;
            this.Music = Musics.Overworld_SMB;
            this.Length = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zone class based on a zone of a level
        /// </summary>
        /// <param name="level">The level to retrieve information</param>
        /// <param name="zone">The zone to get information</param>
        public Zone(Level level, Zones zone)
        {
            // Retrieves the level background, the music, and the screen length
            int background = int.Parse(level.Pieces[(int)zone + 1]);
            int music = int.Parse(level.Pieces[(int)zone + 4]);
            int length = int.Parse(level.Pieces[(int)zone + 5]);

            // Make sure the background number doesn't exceed 6 and go below 1
            if ((background < 1) && (background > 6))
            {
                throw new LevelException(string.Format("The background number in the {0} Zone is not between 1 and 6. (The background number given was {1:N})", zone, background));
            }

            // Make sure the music number doesn't exceed 11 and go below 0
            if ((music < 0) && (music > 11))
            {
                throw new LevelException(string.Format("The music number in the {0} Zone is not between 0 and 11. (The music number given was {1:N})", zone, music));
            }

            // Make sure the length is not absurd 
            if (length < 320)
            {
                throw new LevelException(string.Format("The length of the {0} Zone is not valid because it is less than 0. (The length given was {1:N} screen(s) wide ({2:N} pixel(s) wide)", zone, length - 320, length));
            }
            else if (length > 4500)
            {
                level.AddWarning(string.Format("the length of the {0} Zone exceeds the standard screen size (4,180 screen wide). Level2Pic and Super Mario Flash will only show up to the standard screen size. (The length given was {1:N} screen(s) wide ({2:N} pixel(s) wide)", zone, length - 320, length));
            }

            this.Background = (Backgrounds)background;
            this.Length = length;
            this.Music = (Musics)music;
        }

        /// <summary>
        /// Gets or sets the background of the zone
        /// </summary>
        public Backgrounds Background
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the length of the zone (in &quot;pixels&quot;)
        /// </summary>
        public int Length
        {
            get
            {
                return this.zoneLength;
            }

            set
            {
                // Make sure the value isn't less than 0
                if (value < 320)
                {
                    throw new LevelException("The length specified is less than 320 pixels (less than 0 screens wide).");
                }
                else
                {
                    this.zoneLength = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the music to be played of the zone
        /// </summary>
        public Musics Music
        {
            get;
            set;
        }
    }
}
