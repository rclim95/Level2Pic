// <copyright file="Level.cs" company="NZoid154 Softwares">
// Copyright (c) 2010
// </copyright>
namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents a Super Mario Flash v3.0 level
    /// </summary>
    public class Level
    {
        /// <summary>
        /// The proprties about the Bonus Zone
        /// </summary>
        private Zone bonus;

        /// <summary>
        /// Counts the number of times a tiles have been used.
        /// </summary>
        private Dictionary<int, int> counter;

        /// <summary>
        /// The level code in &quot;pieces&quot; as an array
        /// </summary>
        private string[] levelPieces;

        /// <summary>
        /// The level code in &quot;pieces&quot; as an array. This one will be used to return the level as a code.
        /// </summary>
        private string[] levelPiecesToReturn;

        /// <summary>
        /// The level code currently loaded
        /// </summary>
        private string loadedLevelCode = string.Empty;

        /// <summary>
        /// The properties about the Main Zone
        /// </summary>
        private Zone main;

        /// <summary>
        /// The list of warnings found while validating the level code
        /// </summary>
        private List<string> warnings = new List<string>();

        /// <summary>
        /// Contains all the warp information for the level
        /// </summary>
        private string warpInformation;

        /// <summary>
        /// Initializes a new instance of the Level class
        /// </summary>
        /// <param name="code">The Super Mario Flash code to load</param>
        public Level(string code)
        {
            string cleanCode = this.CleanCode(code);

            // Set global variables
            this.counter = new Dictionary<int, int>();
            this.loadedLevelCode = code;
            this.levelPieces = cleanCode.Split(',');

            // Correct amount of code?
            if (this.levelPieces.Length != 5413)
            {
                throw new LevelException(string.Format(
                    "The number of items in the level code is invalid. A valid level code contains 5,413 items. This level contains {0:N} items.",
                    this.levelPieces.Length));
            }

            // To prevent changes, create a "backup" copy of the level pieces
            this.levelPiecesToReturn = (string[])this.levelPieces.Clone();

            // Looping through the level pieces to check for stuff and gather information
            for (int piece = 0; piece < this.levelPieces.Length; piece++)
            {
                int outputNumber = 0;
                
                // Make sure we're not checking level names and tile 5412
                if (piece != 2700 && piece != 5406 && piece != 5412)
                {
                    // Parsing number...
                    if (int.TryParse(this.levelPieces[piece], out outputNumber) == false)
                    {
                        this.warnings.Add(string.Format("At position {0:N}, \"{1}\" is not a number. The tile have been replaced with the number \"0\".", piece, this.levelPieces[piece]));
                        this.levelPieces[piece] = "0";
                    }
                }

                // Make sure we dont' mess with the information part of the level
                if ((piece >= 0 && piece <= 2699) || (piece >= 2706 && piece <= 5405))
                {
                    // Checking warps to see if their "partner" is still there...
                    if ((this.levelPieces[piece] == "152" && this.levelPieces[piece - 1] != "151") ||
                        (this.levelPieces[piece] == "158" && this.levelPieces[piece - 1] != "157") ||
                        (this.levelPieces[piece] == "154" && this.levelPieces[piece - 225] != "153") ||
                        (this.levelPieces[piece] == "156" && this.levelPieces[piece - 255] != "155"))
                    {
                        // ... if not, then set the warp point to 0. Log this to the warning also.
                        this.warnings.Add(string.Format("At position {0:N}, the tile is missing one of its warp tile beside it. The tile have been replaced with the number \"0\" for appearance reasons.", piece));
                        this.levelPieces[piece] = "0";
                    }

                    // Add it to the counter...
                    if (this.counter.ContainsKey(outputNumber))
                    {
                        this.counter[outputNumber]++;
                    }
                    else
                    {
                        this.counter.Add(outputNumber, 0);
                        this.counter[outputNumber]++;
                    }
                }
            }

            // Set stuff needed so we can return the code sucessfully
            this.warpInformation = code.Substring(Regex.Matches(code, "\\(")[2].Index); 
            this.levelPiecesToReturn[0] = "(" + this.levelPiecesToReturn[0];
            this.levelPiecesToReturn[2706] = ")(" + this.levelPiecesToReturn[2706];
            this.levelPiecesToReturn[5412] += ")";
           
            this.bonus = new Zone(this, Zones.Bonus);
            this.main = new Zone(this, Zones.Main);
        }

        /// <summary>
        /// Gets or sets the properties of the Bonus Room
        /// </summary>
        public Zone Bonus
        {
            get
            {
                return this.bonus;
            }

            set
            {
                this.bonus = value;
            }
        }

        /// <summary>
        /// Gets the number of tiles and enemies used. The key represents the tile ID while the value represents the uses.
        /// </summary>
        public Dictionary<int, int> Count
        {
            get
            {
                return this.counter;
            }
        }

        /// <summary>
        /// Gets or sets the properties of the Main Zone
        /// </summary>
        public Zone Main
        {
            get
            {
                return this.main;
            }

            set
            {
                this.main = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the level
        /// </summary>
        public string Name
        {
            get
            {
                // Determine if the name exceeds 100 characters (in case it needs trimming)
                if (this.levelPieces[2700].Length > 100)
                {
                    return (this.levelPieces[2700].Substring(0, 97) + "...").Replace("&", Environment.NewLine);
                }
                else
                {
                    return this.levelPieces[2700].Replace("&", Environment.NewLine);
                }
            }

            set
            {
                string name = value;

                // Contains illegal characters?
                if (Regex.Matches(name, "(\\(|\\)|,)").Count > 0)
                {
                    throw new LevelException("The name you have specified is invalid because it contains parentheses and/or commas.");
                }

                // Determine if the value exceeds 100 characters (in case it needs trimming)
                if (name.Length > 100)
                {
                    name = name.Substring(0, 97) + "...";
                }

                this.levelPieces[2700] = name.Replace(Environment.NewLine, "&");
                this.levelPiecesToReturn[2700] = name.Replace(Environment.NewLine, "&");
            }
        }

        /// <summary>
        /// Gets the pieces of the level
        /// </summary>
        public string[] Pieces
        {
            get
            {
                return this.levelPieces;
            }
        }

        /// <summary>
        /// Gets the warnings that occured while validating the level
        /// </summary>
        public string[] Warnings
        {
            get
            {
                return this.warnings.ToArray();
            }
        }

        /// <summary>
        /// Converts the string representation of a level into its Level equivalent
        /// </summary>
        /// <param name="code">The code to parse</param>
        /// <param name="result">The code as a Level object</param>
        /// <returns>Returns a value </returns>
        public static bool TryParse(string code, out Level result)
        {
            try
            {
                /* 
                 * Initializes a new Level object, and attempt to test if for exceptions.
                 * If any exceptions has been thrown, the return result will be false.
                 * Otherwise, the return result will be true and the level tested will be set to the result.
                 * TODO: Find a more efficient way to do this instead of testing for exceptions
                 */

                Level level = new Level(code);
                Zone mainZone = level.Main;
                Zone bonusZone = level.Bonus;

                result = level;
                return true;
            }
            catch (Exception)
            {
                result = null;
            }

            return false;
        }

        /// <summary>
        /// Returns the level as a Super Mario Flash code
        /// </summary>
        /// <returns>The level code based on the properties set</returns>
        public string ToCode()
        {
            string codeToReturn = string.Empty;

            // Zone properties to edit
            this.levelPiecesToReturn[(int)Zones.Main + 1] = ((int)this.Main.Background).ToString();   // Main Zone - Background
            this.levelPiecesToReturn[(int)Zones.Main + 4] = ((int)this.Main.Music).ToString();        // Main Zone - Music
            this.levelPiecesToReturn[(int)Zones.Main + 5] = ((int)this.Main.Length).ToString();       // Main Zone - Length
            this.levelPiecesToReturn[(int)Zones.Bonus + 1] = ((int)this.Bonus.Background).ToString(); // Bonus Zone - Background
            this.levelPiecesToReturn[(int)Zones.Bonus + 4] = ((int)this.Bonus.Music).ToString();      // Bonus Zone - Music
            this.levelPiecesToReturn[(int)Zones.Bonus + 5] = ((int)this.Bonus.Length).ToString();     // Bonus Zone - Length

            // Begin appending it to the codeToReturn
            foreach (string piece in this.levelPiecesToReturn)
            {
                // If the tile itself is just a parenthesis, then it must be the end. Do not append a comma after it.
                if (piece != ")")
                {
                    codeToReturn += piece + ",";
                }
                else
                {
                    codeToReturn += piece;
                }
            }

            // Append warp information
            codeToReturn += this.warpInformation;

            return codeToReturn;
        }

        /// <summary>
        /// Adds a warning to the Warning list of the level
        /// </summary>
        /// <param name="warning">The warning to add to the list</param>
        internal void AddWarning(string warning)
        {
            this.warnings.Add(warning);
        }

        /// <summary>
        /// &quot;Cleans&quot; the level code, removing unnecessary parenthesis and warp information
        /// </summary>
        /// <param name="code">The level code to clean</param>
        /// <returns>The level code, without parenthesis, line breaks, white spaces, and warp information</returns>
        private string CleanCode(string code)
        {
            string codeToClean = code;

            // Remove all white-spaces to prevent any sort of issues
            codeToClean = codeToClean.Trim();

            // Verify that the number of parenthesis total 8, where there are 4 start and end parenthesis
            if ((Regex.Matches(code, "\\(").Count != 4) || (Regex.Matches(code, "\\)").Count != 4))
            {
                throw new LevelException(string.Format("Unable to find 4 staring parentheses or 4 ending parentheses. This level code contains {0:N} starting parentheses and {1:N} ending parentheses.", Regex.Matches(codeToClean, "\\(").Count, Regex.Matches(codeToClean, "\\)").Count));
            }

            // Remove the last two parentheses group (warp info not needed) and replace any existing parentheses
            codeToClean = codeToClean.Remove(codeToClean.LastIndexOf('('));
            codeToClean = codeToClean.Remove(codeToClean.LastIndexOf('('));
            codeToClean = codeToClean.Replace("(", string.Empty);
            codeToClean = codeToClean.Replace(")", string.Empty);

            return codeToClean;
        }
    }
}
