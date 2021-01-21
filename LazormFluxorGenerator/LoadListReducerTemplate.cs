﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LazormFluxorGenerator {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    
    public partial class LoadListReducerTemplate : LoadListReducerTemplateBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 6 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 7 ""

    string EntityClass = entityClassName;
    string memberEntity = "_" + entityClassName.ToLower();
    string localEntity = entityClassName.ToLower();
    string currentEntities = "Current" + entityClassNamePlural;

            
            #line default
            #line hidden
            
            #line 13 ""
  
//string[] cruds = new string[] {"Create", "Load", "Update", "Delete"};
string stateClassName = entityClassNamePlural + "State";

            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write("using System.Collections.Generic;\nusing System.Linq;\nusing Fluxor;\nusing Lazorm;\n" +
                    "using Lazorm.Store.Features.");
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassName ));
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write("UseCase.Actions.");
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write(";\nusing Lazorm.Store.States;\n\nnamespace Lazorm.Store.Features.");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassName ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("UseCase.Reducers\n{\n    #region Reducer\n    public static class ");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write("ActionsReducer\n    {\n        [ReducerMethod]\n        public static ");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(" Reduce");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write("Action(");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(" state, ");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write("Action _)\n        => new ");
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write("(true, null, null, state.CurrentEntity);\n\n        [ReducerMethod]\n        public " +
                    "static ");
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(" Reduce");
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write("SuccessAction(");
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(" state, ");
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write("SuccessAction action)\n        {\n");
            
            #line default
            #line hidden
            
            #line 36 ""
 if (crud == "Load" ) { 
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("            return new ");
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("(false, null, action.");
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write(", state.CurrentEntity);\n");
            
            #line default
            #line hidden
            
            #line 38 ""

    } /* end Load */

            
            #line default
            #line hidden
            
            #line 41 ""
            this.Write("        }\n\n        [ReducerMethod]\n            public static ");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(" Reduce");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("FailureAction(");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(" state, ");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( crud ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( entityClassNamePlural ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("FailureAction action)\n            => new ");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( stateClassName ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write("(false, action.ErrorMessage, null, state.CurrentEntity );    \n        \n    }\n    " +
                    "#endregion Reducer\n}\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class LoadListReducerTemplateBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
