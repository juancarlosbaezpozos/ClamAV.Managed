﻿/*
 * ClamAV.Managed - Managed bindings for ClamAV
 * Copyright (C) 2011, 2013 Rupert Muchembled
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClamAV.Managed
{
    /// <summary>
    /// Error status corresponding to ClamAV error codes.
    /// </summary>
    public enum ClamError : uint
    {
        Clean = 0,
        Success = 0,
        Virus,
        NullArgError,
        ArgError,
        MalformedDatabaseError,
        CvdError,
        VerificationError,
        UnpackError,

        OpenError,
        CreateError,
        UnlinkError,
        StatError,
        ReadError,
        SeekError,
        WriteError,
        DupError,
        AccessError,
        TempFileError,
        TempDirError,
        MapError,
        MemError,
        TimeoutError,

        BreakError,
        MaxRecursionError,
        MaxSizeError,
        MaxFilesError,
        FormatError,
        BytecodeError,
        BytecodeTestFailError,

        LockError,
        BusyError,
        StateError,

        LastError
    }
}