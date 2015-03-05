﻿namespace GostCryptography.Asn1.Ber
{
	interface IAsn1NamedEventHandler
	{
		void Characters(string svalue, short typeCode);
		void EndElement(string name, int index);
		void StartElement(string name, int index);
	}
}