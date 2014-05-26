﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;

namespace SassyStudio
{
    class ScssOptions : DialogPage
    {
        public override void LoadSettingsFromStorage()
        {
            // defaults
            GenerateCssOnSave = true;
            GenerateMinifiedCssOnSave = true;
            IncludeCssInProject = true;
            IncludeCssInProjectOutput = true;
            IncludeSourceComments = false;
            GenerateSourceMaps = false;
            ReplaceCssWithException = false;
            IncludeGeneratedCodeWarning = false;

            base.LoadSettingsFromStorage();
        }

        [LocDisplayName("Replace .css with exception")]
        [Description("When enabled, the contents of the .css file will be replaced with exception information when there is an error generating the document.")]
        [Category("SCSS")]
        public bool ReplaceCssWithException { get; set; }

        [LocDisplayName("Generate .css on save")]
        [Description("When enabled, a css file with the same name will be generated")]
        [Category("SCSS")]
        public bool GenerateCssOnSave { get; set; }

        [LocDisplayName("CSS Generation Output Directory")]
        [Description("When directory name provided (ie css) then all generated css files will end up in a top-level, sibling directory by that name.")]
        [Category("SCSS")]
        public string CssGenerationOutputDirectory { get; set; }

        [LocDisplayName("Generate minified .css file on save")]
        [Description("When enabled, a .min.css file with the same name will be generated")]
        [Category("SCSS")]
        public bool GenerateMinifiedCssOnSave { get; set; }

        [LocDisplayName("Include .css in project")]
        [Description("When .css file is generated it will be added as nested file of .scss file")]
        [Category("SCSS")]
        public bool IncludeCssInProject { get; set; }

        [LocDisplayName("Include .css in project output")]
        [Description("When enabled, the generated .css file will have it's Build Action set to Content")]
        [Category("SCSS")]
        public bool IncludeCssInProjectOutput { get; set; }

        [LocDisplayName("Source Comments")]
        [Description("When enabled, comments will be added to the .css file specifying the file and line number where the values originated from.")]
        [Category("SCSS")]
        public bool IncludeSourceComments { get; set; }

        [LocDisplayName("Experimental Intellisense")]
        [Description("When enabled, statement completion will be enabled for variables, functions, mixins and keywords.")]
        [Category("Intellisense")]
        public bool EnableExperimentalIntellisense { get; set; }

        [LocDisplayName("Include Paths")]
        [Description("A semicolon separated list of directories to include in consideration when generating .css file. This is to support SCSS frameworks like Compass.")]
        [Category("SCSS")]
        public string CompilationIncludePaths { get; set; }

        [LocDisplayName("Ruby Install Path")]
        [Description("The directory that ruby is installed in")]
        [Category("Compass")]
        public string RubyInstallPath { get; set; }

        [LocDisplayName("Debug Logging")]
        [Description("When enabled, more information will be logged")]
        [Category("Diagnostics")]
        public bool IsDebugLoggingEnabled { get; set; }

        [LocDisplayName("Generated Code Warning")]
        [Description("When enabled, a warning will be emitted to CSS files that the file was generated by compiler.")]
        [Category("Diagnostics")]
        public bool IncludeGeneratedCodeWarning { get; set; }

        [LocDisplayName("Generate Source Map")]
        [Description("When enabled, a source map file will be generated.")]
        [Category("SCSS")]
        public bool GenerateSourceMaps { get; set; }
    }
}
