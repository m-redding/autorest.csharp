// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary> The second level model in polymorphic single levels inheritance which contains references to other polymorphic instances. </summary>
    public partial class Eagle : Bird
    {
        /// <summary> Initializes a new instance of <see cref="Eagle"/>. </summary>
        /// <param name="wingspan"></param>
        public Eagle(int wingspan) : base(wingspan)
        {
            Kind = "eagle";
            Friends = new ChangeTrackingList<Bird>();
            Hate = new ChangeTrackingDictionary<string, Bird>();
        }

        /// <summary> Initializes a new instance of <see cref="Eagle"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="wingspan"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="friends">
        /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
        /// </param>
        /// <param name="hate">
        /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
        /// </param>
        /// <param name="partner">
        /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
        /// </param>
        internal Eagle(string kind, int wingspan, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<Bird> friends, IDictionary<string, Bird> hate, Bird partner) : base(kind, wingspan, serializedAdditionalRawData)
        {
            Friends = friends;
            Hate = hate;
            Partner = partner;
        }

        /// <summary> Initializes a new instance of <see cref="Eagle"/> for deserialization. </summary>
        internal Eagle()
        {
        }

        /// <summary>
        /// Gets the friends
        /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
        /// </summary>
        public IList<Bird> Friends { get; }
        /// <summary>
        /// Gets the hate
        /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
        /// </summary>
        public IDictionary<string, Bird> Hate { get; }
        /// <summary>
        /// Gets or sets the partner
        /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
        /// </summary>
        public Bird Partner { get; set; }
    }
}