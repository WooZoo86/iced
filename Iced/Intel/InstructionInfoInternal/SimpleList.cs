﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_INSTR_INFO
namespace Iced.Intel.InstructionInfoInternal {
	struct SimpleList<T> {
		public static readonly SimpleList<T> Empty = new SimpleList<T>(System.Array.Empty<T>());
		public T[] Array;
		public int ValidLength;
		public SimpleList(T[] array) {
			Array = array;
			ValidLength = 0;
		}
	}
}
#endif
