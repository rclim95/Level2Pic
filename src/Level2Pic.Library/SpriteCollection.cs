// <copyright file="SpriteCollection.cs" company="NZoid154 Softwares">
// Copyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// Represents an ordered collection of sprites.
    /// </summary>
    [Serializable()]
    [XmlInclude(typeof(Sprite))]
    public class SpriteCollection : IDictionary<int, Sprite>
    {
        /// <summary>
        /// The dictionary that holds this collection.
        /// </summary>
        private Dictionary<int, Sprite> dictionary = new Dictionary<int, Sprite>();

        /// <summary>
        /// Gets the number of sprites that is in the collection.
        /// </summary>
        public int Count
        {
            get
            {
                return this.dictionary.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the collection is read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a collection containing the keys of the sprite collection.
        /// </summary>
        public ICollection<int> Keys
        {
            get
            {
                return this.dictionary.Keys;
            }
        }

        /// <summary>
        /// Gets a collection containing the values of the sprite collection.
        /// </summary>
        public ICollection<Sprite> Values
        {
            get
            {
                return this.dictionary.Values;
            }
        }

        /// <summary>
        /// Gets or sets a sprite at the specified key.
        /// </summary>
        /// <param name="key">The key of the element to get or set.</param>
        /// <returns>The element with the specified key.</returns>
        public Sprite this[int key]
        {
            get
            {
                return this.dictionary[key];
            }

            set
            {
                this.dictionary[key] = value;
            }
        }

        /// <summary>
        /// Adds the specified key and value into the collection.
        /// </summary>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add. The value can be null.</param>
        public void Add(int key, Sprite value)
        {
            this.dictionary.Add(key, value);
        }        
        
        /// <summary>
        /// Adds the specified key and value into the collection
        /// </summary>
        /// <param name="item">The key and value to add into the collection.</param>
        public void Add(KeyValuePair<int, Sprite> item)
        {
            this.dictionary.Add(item.Key, item.Value);
        }

        /// <summary>
        /// Determine whether the collection contains the following key.
        /// </summary>
        /// <param name="item">The key and value to locate in the collection.</param>
        /// <returns>True if the item is in the collection; false if the item isn't in the collection.</returns>
        public bool Contains(KeyValuePair<int, Sprite> item)
        {
            return this.dictionary.Contains(item);
        }

        /// <summary>
        /// Determine whether the collection contains the following key.
        /// </summary>
        /// <param name="key">The key to locate in the collection.</param>
        /// <returns>True if the item is in the collection; false if the item isn't in the collection.</returns>
        public bool ContainsKey(int key)
        {
            return this.dictionary.ContainsKey(key);
        }

        /// <summary>
        /// Removes all sprites in the collection.
        /// </summary>
        public void Clear()
        {
            this.dictionary.Clear();
        }

        /// <summary>
        /// Copies the item of the collection into an array, starting at the array's index;
        /// </summary>
        /// <param name="array">The array to copy the collection into.</param>
        /// <param name="arrayIndex">The zero-based index at which the copying begins.</param>
        public void CopyTo(KeyValuePair<int, Sprite>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the collection.</returns>
        public IEnumerator<KeyValuePair<int, Sprite>> GetEnumerator()
        {
            return this.dictionary.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through athe collection.</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.dictionary.GetEnumerator();
        }

        /// <summary>
        /// Removes the first occurence of the specified object from the collection.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        /// <returns>True if the item has been sucessful; otherwise, false if the item doesn't exist or wasn't removed.</returns>
        public bool Remove(KeyValuePair<int, Sprite> item)
        {
            return this.Remove(item);
        }

        /// <summary>
        /// Removes the sprite with the specified key from the collection.
        /// </summary>
        /// <param name="key">The key of the element to remove.</param>
        /// <returns>True if the item has been sucessful; otherwise, false if the item doesn't exist or wanted removed.</returns>
        public bool Remove(int key)
        {
            return this.Remove(key);
        }

        /// <summary>
        /// Get the value associated with the key specified.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
        /// <returns>True if the collection contains an element with the specified key; otherwise, false.</returns>
        public bool TryGetValue(int key, out Sprite value)
        {
            return this.TryGetValue(key, out value);
        }
    }
}
