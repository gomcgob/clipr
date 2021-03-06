﻿using clipr.Arguments;
using clipr.Core;
using System;

namespace clipr
{
    /// <summary>
    /// <para>
    /// A required argument, ordered based on Index in ascending order.
    /// </para>
    /// <para>
    /// Only the last argument in the positional list may have
    /// a variable number of argument values.
    /// </para>
    /// </summary>
    public class PositionalArgumentAttribute : ArgumentAttribute, IPositionalArgument
    {
        /// <summary>
        /// Index in the positional argument list for this argument.
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        /// Create a new positional argument at the given index.
        /// </summary>
        /// <param name="index">Positional index.</param>
        public PositionalArgumentAttribute(int index)
        {
            Index = index;
        }

        /// <summary>
        /// An argument name suitable for displaying on a help page.
        /// 
        /// Defaults to either the short or long name.
        /// </summary>
        public override string MetaVar
        {
            get
            {
                if (!String.IsNullOrEmpty(base.MetaVar))
                {
                    return base.MetaVar;
                }
                if (!String.IsNullOrEmpty(Name))
                {
                    return Name;
                }

                return null;
            }
            set
            {
                base.MetaVar = value;
            }
        }
    }
}
