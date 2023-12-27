﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MauiReactor.ScaffoldGenerator
{
    public partial class ComponentPartialClassGenerator
    {
        private readonly GeneratorClassItem _classItem;

        public ComponentPartialClassGenerator(GeneratorClassItem classItem)
        {
            _classItem = classItem;
        }

        public string TransformAndPrettify()
        {
            var tree = CSharpSyntaxTree.ParseText(TransformText());
            var root = tree.GetRoot().NormalizeWhitespace();
            var ret = root.ToFullString();
            return $"// <auto-generated />{Environment.NewLine}{ret}";
        }

        private string GetPropMethodName(string fieldName)
        {
            fieldName = fieldName.TrimStart('_');
            fieldName = char.ToUpper(fieldName[0]) + fieldName.Substring(1);
            return fieldName;
        }

        private IEnumerable<GeneratorFieldItem> GetInjectFields()
        {
            return _classItem.FieldItems.Where(_ => _.Value.Type == FieldAttributeType.Inject).OrderBy(_ => _.Key).Select(_=>_.Value);
        }
        private IEnumerable<GeneratorFieldItem> GetPropFields()
        {
            return _classItem.FieldItems.Where(_ => _.Value.Type == FieldAttributeType.Prop).OrderBy(_ => _.Key).Select(_ => _.Value);
        }
    }
}
