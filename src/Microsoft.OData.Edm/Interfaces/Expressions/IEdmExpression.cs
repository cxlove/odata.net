//---------------------------------------------------------------------
// <copyright file="IEdmExpression.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.Edm.Expressions
{
    /// <summary>
    /// Defines EDM expression kinds.
    /// </summary>
    public enum EdmExpressionKind
    {
        /// <summary>
        /// Represents an expression with unknown or error kind.
        /// </summary>
        None = 0,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmBinaryConstantExpression"/>.
        /// </summary>
        BinaryConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmBooleanConstantExpression"/>.
        /// </summary>
        BooleanConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmDateTimeOffsetConstantExpression"/>.
        /// </summary>
        DateTimeOffsetConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmDecimalConstantExpression"/>.
        /// </summary>
        DecimalConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmFloatingConstantExpression"/>.
        /// </summary>
        FloatingConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmGuidConstantExpression"/>.
        /// </summary>
        GuidConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmIntegerConstantExpression"/>.
        /// </summary>
        IntegerConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmStringConstantExpression"/>.
        /// </summary>
        StringConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmDurationConstantExpression"/>.
        /// </summary>
        DurationConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmNullExpression"/>.
        /// </summary>
        Null,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmRecordExpression"/>.
        /// </summary>
        Record,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmCollectionExpression"/>.
        /// </summary>
        Collection,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmPathExpression"/>.
        /// </summary>
        Path,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmParameterReferenceExpression"/>.
        /// </summary>
        ParameterReference,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmOperationReferenceExpression"/>.
        /// </summary>
        OperationReference,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmPropertyReferenceExpression"/>.
        /// </summary>
        PropertyReference,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmValueTermReferenceExpression"/>.
        /// </summary>
        ValueTermReference,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmEntitySetReferenceExpression"/>.
        /// </summary>
        EntitySetReference,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmEnumMemberReferenceExpression"/>.
        /// </summary>
        EnumMemberReference,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmIfExpression"/>.
        /// </summary>
        If,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmCastExpression"/>.
        /// </summary>
        Cast,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmIsTypeExpression"/>.
        /// </summary>
        IsType,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmApplyExpression"/>.
        /// </summary>
        OperationApplication,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmLabeledExpressionReferenceExpression"/>.
        /// </summary>
        LabeledExpressionReference,

        /// <summary>
        /// Represents an expression implementing <see cref=" IEdmLabeledExpression"/>
        /// </summary>
        Labeled,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmPathExpression"/>.
        /// </summary>
        PropertyPath,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmPathExpression"/>.
        /// </summary>
        NavigationPropertyPath,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmDateConstantExpression"/>.
        /// </summary>
        DateConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmTimeOfDayConstantExpression"/>.
        /// </summary>
        TimeOfDayConstant,

        /// <summary>
        /// Represents an expression implementing <see cref="IEdmEnumMemberExpression"/>.
        /// </summary>
        EnumMember
    }

    /// <summary>
    /// Represents an EDM expression.
    /// </summary>
    public interface IEdmExpression : IEdmElement
    {
        /// <summary>
        /// Gets the kind of this expression.
        /// </summary>
        EdmExpressionKind ExpressionKind { get; }
    }
}
