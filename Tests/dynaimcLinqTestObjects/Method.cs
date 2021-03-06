﻿using ExpressionTreeTestObjects;
using System.Linq;
using System.Linq.Expressions;

namespace ExpressionTreeToString.Tests {
    public static partial class DynamicLinqTestObjects {
        [TestObject("Method")]
        internal static readonly Expression StringConcat = Expr(p => string.Concat(p.LastName, p.FirstName));

        [TestObject("Method")]
        internal static readonly Expression Contains = Expr(p => p.Relatives.Contains(p));

        [TestObject("Method")]
        internal static readonly Expression IndexerMethod = Expr(p => p.Relatives2[4]);

        // pending https://github.com/zzzprojects/System.Linq.Dynamic.Core/issues/440
        //[TestObject("Method")]
        //internal static readonly Expression RecgonizedSequenceMethod = Expr(p => p.LastName.All(c => c > 'm'));

        [TestObject("Method")]
        internal static readonly Expression StaticMethod = Expr(p => string.IsInterned("abcd"));

        [TestObject("Method")]
        internal static readonly Expression ParameterMethod = Expr(p => p.ToString());

        [TestObject("Method")]
        internal static readonly Expression InstanceMethodAccessibleType = Expr(p => p.LastName!.ToString());

        // this only works because it returns an accessible type
        [TestObject("Method")]
        internal static readonly Expression InstanceMethodInaccessibleType = Expr(p => p.Notify());
    }
}
