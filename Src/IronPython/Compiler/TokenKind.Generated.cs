// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.Scripting;

namespace IronPython.Compiler {

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dedent")]
    public enum TokenKind {
        EndOfFile = -1,
        Error = 0,
        NewLine = 1,
        Indent = 2,
        Dedent = 3,
        Comment = 4,
        Name = 8,
        Constant = 9,
        Dot = 31,
        At = MatMult,

        #region Generated Token Kinds

        // *** BEGIN GENERATED CODE ***
        // generated by function: tokenkinds_generator from: generate_ops.py

        Add = 32,
        AddEqual = 33,
        Subtract = 34,
        SubtractEqual = 35,
        Power = 36,
        PowerEqual = 37,
        Multiply = 38,
        MultiplyEqual = 39,
        MatMult = 40,
        MatMultEqual = 41,
        FloorDivide = 42,
        FloorDivideEqual = 43,
        TrueDivide = 44,
        TrueDivideEqual = 45,
        Mod = 46,
        ModEqual = 47,
        LeftShift = 48,
        LeftShiftEqual = 49,
        RightShift = 50,
        RightShiftEqual = 51,
        BitwiseAnd = 52,
        BitwiseAndEqual = 53,
        BitwiseOr = 54,
        BitwiseOrEqual = 55,
        ExclusiveOr = 56,
        ExclusiveOrEqual = 57,
        LessThan = 58,
        GreaterThan = 59,
        LessThanOrEqual = 60,
        GreaterThanOrEqual = 61,
        Equals = 62,
        NotEquals = 63,
        LeftParenthesis = 64,
        RightParenthesis = 65,
        LeftBracket = 66,
        RightBracket = 67,
        LeftBrace = 68,
        RightBrace = 69,
        Comma = 70,
        Colon = 71,
        Semicolon = 72,
        Assign = 73,
        Twiddle = 74,
        RightArrow = 75,
        ReturnAnnotation = 76,

        FirstKeyword = KeywordAnd,
        LastKeyword = KeywordNonlocal,
        KeywordAnd = 77,
        KeywordAssert = 78,
        KeywordBreak = 79,
        KeywordClass = 80,
        KeywordContinue = 81,
        KeywordDef = 82,
        KeywordDel = 83,
        KeywordElseIf = 84,
        KeywordElse = 85,
        KeywordExcept = 86,
        KeywordFinally = 87,
        KeywordFor = 88,
        KeywordFrom = 89,
        KeywordGlobal = 90,
        KeywordIf = 91,
        KeywordImport = 92,
        KeywordIn = 93,
        KeywordIs = 94,
        KeywordLambda = 95,
        KeywordNot = 96,
        KeywordOr = 97,
        KeywordPass = 98,
        KeywordRaise = 99,
        KeywordReturn = 100,
        KeywordTry = 101,
        KeywordWhile = 102,
        KeywordYield = 103,
        KeywordAs = 104,
        KeywordWith = 105,
        KeywordAsync = 106,
        KeywordNonlocal = 107,

        // *** END GENERATED CODE ***

        #endregion

        NLToken,
    }

    public static class Tokens {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token EndOfFileToken = new SymbolToken(TokenKind.EndOfFile, "<eof>");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token NewLineToken = new SymbolToken(TokenKind.NewLine, "<newline>");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token NLToken = new SymbolToken(TokenKind.NLToken, "<NL>");  // virtual token used for error reporting
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token IndentToken = new SymbolToken(TokenKind.Indent, "<indent>");

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dedent")]
        public static readonly Token DedentToken = new SymbolToken(TokenKind.Dedent, "<dedent>");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token CommentToken = new SymbolToken(TokenKind.Comment, "<comment>");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token NoneToken = new ConstantValueToken(null);
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token TrueToken = new ConstantValueToken(true);
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token FalseToken = new ConstantValueToken(false);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly Token DotToken = new SymbolToken(TokenKind.Dot, ".");

        #region Generated Tokens

        // *** BEGIN GENERATED CODE ***
        // generated by function: tokens_generator from: generate_ops.py

        public static Token AddToken { get; } = new OperatorToken(TokenKind.Add, "+", 4);
        public static Token AddEqualToken { get; } = new SymbolToken(TokenKind.AddEqual, "+=");
        public static Token SubtractToken { get; } = new OperatorToken(TokenKind.Subtract, "-", 4);
        public static Token SubtractEqualToken { get; } = new SymbolToken(TokenKind.SubtractEqual, "-=");
        public static Token PowerToken { get; } = new OperatorToken(TokenKind.Power, "**", 6);
        public static Token PowerEqualToken { get; } = new SymbolToken(TokenKind.PowerEqual, "**=");
        public static Token MultiplyToken { get; } = new OperatorToken(TokenKind.Multiply, "*", 5);
        public static Token MultiplyEqualToken { get; } = new SymbolToken(TokenKind.MultiplyEqual, "*=");
        public static Token MatMultToken { get; } = new OperatorToken(TokenKind.MatMult, "@", 5);
        public static Token MatMultEqualToken { get; } = new SymbolToken(TokenKind.MatMultEqual, "@=");
        public static Token FloorDivideToken { get; } = new OperatorToken(TokenKind.FloorDivide, "//", 5);
        public static Token FloorDivideEqualToken { get; } = new SymbolToken(TokenKind.FloorDivideEqual, "//=");
        public static Token TrueDivideToken { get; } = new OperatorToken(TokenKind.TrueDivide, "/", 5);
        public static Token TrueDivideEqualToken { get; } = new SymbolToken(TokenKind.TrueDivideEqual, "/=");
        public static Token ModToken { get; } = new OperatorToken(TokenKind.Mod, "%", 5);
        public static Token ModEqualToken { get; } = new SymbolToken(TokenKind.ModEqual, "%=");
        public static Token LeftShiftToken { get; } = new OperatorToken(TokenKind.LeftShift, "<<", 3);
        public static Token LeftShiftEqualToken { get; } = new SymbolToken(TokenKind.LeftShiftEqual, "<<=");
        public static Token RightShiftToken { get; } = new OperatorToken(TokenKind.RightShift, ">>", 3);
        public static Token RightShiftEqualToken { get; } = new SymbolToken(TokenKind.RightShiftEqual, ">>=");
        public static Token BitwiseAndToken { get; } = new OperatorToken(TokenKind.BitwiseAnd, "&", 2);
        public static Token BitwiseAndEqualToken { get; } = new SymbolToken(TokenKind.BitwiseAndEqual, "&=");
        public static Token BitwiseOrToken { get; } = new OperatorToken(TokenKind.BitwiseOr, "|", 0);
        public static Token BitwiseOrEqualToken { get; } = new SymbolToken(TokenKind.BitwiseOrEqual, "|=");
        public static Token ExclusiveOrToken { get; } = new OperatorToken(TokenKind.ExclusiveOr, "^", 1);
        public static Token ExclusiveOrEqualToken { get; } = new SymbolToken(TokenKind.ExclusiveOrEqual, "^=");
        public static Token LessThanToken { get; } = new OperatorToken(TokenKind.LessThan, "<", -1);
        public static Token GreaterThanToken { get; } = new OperatorToken(TokenKind.GreaterThan, ">", -1);
        public static Token LessThanOrEqualToken { get; } = new OperatorToken(TokenKind.LessThanOrEqual, "<=", -1);
        public static Token GreaterThanOrEqualToken { get; } = new OperatorToken(TokenKind.GreaterThanOrEqual, ">=", -1);
        public static Token EqualsToken { get; } = new OperatorToken(TokenKind.Equals, "==", -1);
        public static Token NotEqualsToken { get; } = new OperatorToken(TokenKind.NotEquals, "!=", -1);
        public static Token LeftParenthesisToken { get; } = new SymbolToken(TokenKind.LeftParenthesis, "(");
        public static Token RightParenthesisToken { get; } = new SymbolToken(TokenKind.RightParenthesis, ")");
        public static Token LeftBracketToken { get; } = new SymbolToken(TokenKind.LeftBracket, "[");
        public static Token RightBracketToken { get; } = new SymbolToken(TokenKind.RightBracket, "]");
        public static Token LeftBraceToken { get; } = new SymbolToken(TokenKind.LeftBrace, "{");
        public static Token RightBraceToken { get; } = new SymbolToken(TokenKind.RightBrace, "}");
        public static Token CommaToken { get; } = new SymbolToken(TokenKind.Comma, ",");
        public static Token ColonToken { get; } = new SymbolToken(TokenKind.Colon, ":");
        public static Token SemicolonToken { get; } = new SymbolToken(TokenKind.Semicolon, ";");
        public static Token AssignToken { get; } = new SymbolToken(TokenKind.Assign, "=");
        public static Token TwiddleToken { get; } = new SymbolToken(TokenKind.Twiddle, "~");
        public static Token RightArrowToken { get; } = new SymbolToken(TokenKind.RightArrow, "=>");
        public static Token ReturnAnnotationToken { get; } = new SymbolToken(TokenKind.ReturnAnnotation, "->");

        public static Token KeywordAndToken { get; } = new SymbolToken(TokenKind.KeywordAnd, "and");
        public static Token KeywordAsToken { get; } = new SymbolToken(TokenKind.KeywordAs, "as");
        public static Token KeywordAssertToken { get; } = new SymbolToken(TokenKind.KeywordAssert, "assert");
        public static Token KeywordAsyncToken { get; } = new SymbolToken(TokenKind.KeywordAsync, "async");
        public static Token KeywordBreakToken { get; } = new SymbolToken(TokenKind.KeywordBreak, "break");
        public static Token KeywordClassToken { get; } = new SymbolToken(TokenKind.KeywordClass, "class");
        public static Token KeywordContinueToken { get; } = new SymbolToken(TokenKind.KeywordContinue, "continue");
        public static Token KeywordDefToken { get; } = new SymbolToken(TokenKind.KeywordDef, "def");
        public static Token KeywordDelToken { get; } = new SymbolToken(TokenKind.KeywordDel, "del");
        public static Token KeywordElseIfToken { get; } = new SymbolToken(TokenKind.KeywordElseIf, "elif");
        public static Token KeywordElseToken { get; } = new SymbolToken(TokenKind.KeywordElse, "else");
        public static Token KeywordExceptToken { get; } = new SymbolToken(TokenKind.KeywordExcept, "except");
        public static Token KeywordFinallyToken { get; } = new SymbolToken(TokenKind.KeywordFinally, "finally");
        public static Token KeywordForToken { get; } = new SymbolToken(TokenKind.KeywordFor, "for");
        public static Token KeywordFromToken { get; } = new SymbolToken(TokenKind.KeywordFrom, "from");
        public static Token KeywordGlobalToken { get; } = new SymbolToken(TokenKind.KeywordGlobal, "global");
        public static Token KeywordIfToken { get; } = new SymbolToken(TokenKind.KeywordIf, "if");
        public static Token KeywordImportToken { get; } = new SymbolToken(TokenKind.KeywordImport, "import");
        public static Token KeywordInToken { get; } = new SymbolToken(TokenKind.KeywordIn, "in");
        public static Token KeywordIsToken { get; } = new SymbolToken(TokenKind.KeywordIs, "is");
        public static Token KeywordLambdaToken { get; } = new SymbolToken(TokenKind.KeywordLambda, "lambda");
        public static Token KeywordNonlocalToken { get; } = new SymbolToken(TokenKind.KeywordNonlocal, "nonlocal");
        public static Token KeywordNotToken { get; } = new SymbolToken(TokenKind.KeywordNot, "not");
        public static Token KeywordOrToken { get; } = new SymbolToken(TokenKind.KeywordOr, "or");
        public static Token KeywordPassToken { get; } = new SymbolToken(TokenKind.KeywordPass, "pass");
        public static Token KeywordRaiseToken { get; } = new SymbolToken(TokenKind.KeywordRaise, "raise");
        public static Token KeywordReturnToken { get; } = new SymbolToken(TokenKind.KeywordReturn, "return");
        public static Token KeywordTryToken { get; } = new SymbolToken(TokenKind.KeywordTry, "try");
        public static Token KeywordWhileToken { get; } = new SymbolToken(TokenKind.KeywordWhile, "while");
        public static Token KeywordWithToken { get; } = new SymbolToken(TokenKind.KeywordWith, "with");
        public static Token KeywordYieldToken { get; } = new SymbolToken(TokenKind.KeywordYield, "yield");

        // *** END GENERATED CODE ***

        #endregion
    }
}
