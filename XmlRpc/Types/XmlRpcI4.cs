﻿namespace XmlRpc.Types {

    /// <summary>
    /// Represents an XmlRpcType containing an int.
    /// </summary>
    public sealed class XmlRpcI4 : XmlRpcInt {

        /// <summary>
        /// Creates a new instance of the <see cref="XmlRpc.Types.XmlRpcI4"/> class with Value set to the default value for int.
        /// </summary>
        public XmlRpcI4()
            : base() { }

        /// <summary>
        /// Creates a new instance of the <see cref="XmlRpc.Types.XmlRpcI4"/> class with the given value.
        /// </summary>
        /// <param name="value">The int encapsulated by this.</param>
        public XmlRpcI4( int value )
            : base( value ) { }

        /// <summary>
        /// The name of Elements of this type.
        /// </summary>
        public override string ContentElementName {
            get { return XmlRpcElements.I4Element; }
        }
    }
}