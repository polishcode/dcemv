/*
*************************************************************************
DC EMV
Open Source EMV
Copyright (C) 2018  Vicente Da Silva

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see http://www.gnu.org/licenses/
*************************************************************************
*/
using DataFormatters;
using DCEMV.TLVProtocol.Common;

namespace DCEMV.EMVProtocol.Kernels
{

    public class EMVTLVMetaDataSource : ITLVMetaDataSource
    {
        public DataFormatterBase GetFormatter(string tag)
        {
            return EMVTagsEnum.GetFormatter(tag);
        }

        public string GetName(string tag)
        {
            string meta = EMVTagsEnum.GetName(tag);
            if (meta == null)
                return null;
            else
                return meta;
        }
    }
}
