﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XmlRpc.Types.Structs
{
    /// <summary>
    /// Gets the struct returned when a method call has a fault.
    /// </summary>
    public sealed class FaultStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the FaultCode property.
        /// </summary>
        private XmlRpcInt faultCode = new XmlRpcInt();

        /// <summary>
        /// Backing field for the FaultString property.
        /// </summary>
        private XmlRpcString faultString = new XmlRpcString();

        /// <summary>
        /// Gets the fault code.
        /// </summary>
        public int FaultCode
        {
            get { return faultCode.Value; }
        }

        /// <summary>
        /// Gets the description of the fault.
        /// </summary>
        public string FaultString
        {
            get { return faultString.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("faultCode", faultCode),
                makeMemberElement("faultString", faultString));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override bool ParseXml(XElement xElement)
        {
            if (!isStructElement(xElement))
                return false;

            foreach (XElement member in xElement.Elements())
            {
                if (!isValidMemberElement(member))
                    return false;

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "faultCode":
                        if (!faultCode.ParseXml(value))
                            return false;
                        break;

                    case "faultString":
                        if (!faultString.ParseXml(value))
                            return false;
                        break;

                    default:
                        return false;
                }
            }

            return true;
        }
    }
}