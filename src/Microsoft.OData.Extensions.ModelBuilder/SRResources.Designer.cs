﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.OData.Extensions.Builder {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SRResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.OData.Extensions.Builder.SRResources", typeof(SRResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be greater than or equal to {0}..
        /// </summary>
        internal static string ArgumentMustBeGreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("ArgumentMustBeGreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be less than or equal to {0}..
        /// </summary>
        internal static string ArgumentMustBeLessThanOrEqualTo {
            get {
                return ResourceManager.GetString("ArgumentMustBeLessThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be of type &apos;{0}&apos;..
        /// </summary>
        internal static string ArgumentMustBeOfType {
            get {
                return ResourceManager.GetString("ArgumentMustBeOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; is null or empty..
        /// </summary>
        internal static string ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; is null, empty or only includes white space..
        /// </summary>
        internal static string ArgumentNullOrWhitespace {
            get {
                return ResourceManager.GetString("ArgumentNullOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot automatically bind the navigation property &apos;{0}&apos; on type &apos;{1}&apos; for the entity set or singleton &apos;{2}&apos; because there are two or more matching target entity sets or singletons. The matching entity sets or singletons are: {3}..
        /// </summary>
        internal static string CannotAutoCreateMultipleCandidates {
            get {
                return ResourceManager.GetString("CannotAutoCreateMultipleCandidates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot define keys on type &apos;{0}&apos; deriving from &apos;{1}&apos;. The base type in the entity inheritance hierarchy already contains keys..
        /// </summary>
        internal static string CannotDefineKeysOnDerivedTypes {
            get {
                return ResourceManager.GetString("CannotDefineKeysOnDerivedTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot redefine property &apos;{0}&apos; already defined on the base type &apos;{1}&apos;..
        /// </summary>
        internal static string CannotRedefineBaseTypeProperty {
            get {
                return ResourceManager.GetString("CannotRedefineBaseTypeProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CollectionProperties must implement IEnumerable&lt;&gt;. The property &apos;{0}&apos; declared on &apos;{1}&apos; does not implement IEnumerable&lt;&gt;..
        /// </summary>
        internal static string CollectionPropertiesMustReturnIEnumerable {
            get {
                return ResourceManager.GetString("CollectionPropertiesMustReturnIEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dependent property type &apos;{0}&apos; is not same as the principal property type &apos;{1}. The dependent and principal properties must have must have same types in the same order..
        /// </summary>
        internal static string DependentAndPrincipalTypeNotMatch {
            get {
                return ResourceManager.GetString("DependentAndPrincipalTypeNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a supported EDM type..
        /// </summary>
        internal static string EdmTypeNotSupported {
            get {
                return ResourceManager.GetString("EdmTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entity set &apos;{0}&apos; was already configured with a different EntityType (&apos;{1}&apos;)..
        /// </summary>
        internal static string EntitySetAlreadyConfiguredDifferentEntityType {
            get {
                return ResourceManager.GetString("EntitySetAlreadyConfiguredDifferentEntityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entity set name &apos;{0}&apos; was already configured as a singleton..
        /// </summary>
        internal static string EntitySetNameAlreadyConfiguredAsSingleton {
            get {
                return ResourceManager.GetString("EntitySetNameAlreadyConfiguredAsSingleton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of left property &apos;{0}.{1}&apos; is &apos;{2}&apos; while the type of right property &apos;{3}.{4}&apos; is &apos;{5}&apos;. The left and right type of the equal expression must be same..
        /// </summary>
        internal static string EqualExpressionsMustHaveSameTypes {
            get {
                return ResourceManager.GetString("EqualExpressionsMustHaveSameTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid bindingParameter type &apos;{0}&apos;. A bindingParameter must be either an EntityType or a Collection of EntityTypes..
        /// </summary>
        internal static string InvalidBindingParameterType {
            get {
                return ResourceManager.GetString("InvalidBindingParameterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid entity set name..
        /// </summary>
        internal static string InvalidEntitySetName {
            get {
                return ResourceManager.GetString("InvalidEntitySetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key mapping for the property &apos;{0}&apos; can&apos;t be null or empty..
        /// </summary>
        internal static string InvalidPropertyMapping {
            get {
                return ResourceManager.GetString("InvalidPropertyMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid singleton name. The singleton name cannot contain &apos;.&apos;..
        /// </summary>
        internal static string InvalidSingletonName {
            get {
                return ResourceManager.GetString("InvalidSingletonName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The LambdaExpression must have exactly one parameter..
        /// </summary>
        internal static string LambdaExpressionMustHaveExactlyOneParameter {
            get {
                return ResourceManager.GetString("LambdaExpressionMustHaveExactlyOneParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The LambdaExpression must have exactly two parameters..
        /// </summary>
        internal static string LambdaExpressionMustHaveExactlyTwoParameters {
            get {
                return ResourceManager.GetString("LambdaExpressionMustHaveExactlyTwoParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change multiplicity of the collection navigation property &apos;{0}&apos;..
        /// </summary>
        internal static string ManyNavigationPropertiesCannotBeChanged {
            get {
                return ResourceManager.GetString("ManyNavigationPropertiesCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on the type &apos;{1}&apos; is being configured as a Many-to-Many navigation property. Many to Many navigation properties must be collections..
        /// </summary>
        internal static string ManyToManyNavigationPropertyMustReturnCollection {
            get {
                return ResourceManager.GetString("ManyToManyNavigationPropertyMustReturnCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MemberExpressions must be bound to the LambdaExpression parameter..
        /// </summary>
        internal static string MemberExpressionsMustBeBoundToLambdaParameter {
            get {
                return ResourceManager.GetString("MemberExpressionsMustBeBoundToLambdaParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Member &apos;{0}.{1}&apos; is not a property..
        /// </summary>
        internal static string MemberExpressionsMustBeProperties {
            get {
                return ResourceManager.GetString("MemberExpressionsMustBeProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found more than one dynamic property container in type &apos;{0}&apos;. Each open type must have at most one dynamic property container..
        /// </summary>
        internal static string MoreThanOneDynamicPropertyContainerFound {
            get {
                return ResourceManager.GetString("MoreThanOneDynamicPropertyContainerFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one Operation called &apos;{0}&apos; was found. Try using the other RemoveOperation override..
        /// </summary>
        internal static string MoreThanOneOperationFound {
            get {
                return ResourceManager.GetString("MoreThanOneOperationFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one matching CLR type found for the EDM type {0}.\nThe matching CLR types are {1}..
        /// </summary>
        internal static string MultipleMatchingClrTypesForEdmType {
            get {
                return ResourceManager.GetString("MultipleMatchingClrTypesForEdmType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; property on &apos;{1}&apos; must be a Collection property..
        /// </summary>
        internal static string MustBeCollectionProperty {
            get {
                return ResourceManager.GetString("MustBeCollectionProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on type &apos;{1}&apos; must be a Complex property..
        /// </summary>
        internal static string MustBeComplexProperty {
            get {
                return ResourceManager.GetString("MustBeComplexProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on type &apos;{1}&apos; must be a System.DateTime property..
        /// </summary>
        internal static string MustBeDateTimeProperty {
            get {
                return ResourceManager.GetString("MustBeDateTimeProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on type &apos;{1}&apos; must be an Enum property..
        /// </summary>
        internal static string MustBeEnumProperty {
            get {
                return ResourceManager.GetString("MustBeEnumProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property  &apos;{0}&apos; on type &apos;{1}&apos; must be a Navigation property..
        /// </summary>
        internal static string MustBeNavigationProperty {
            get {
                return ResourceManager.GetString("MustBeNavigationProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos;  on type &apos;{1}&apos; must be a Primitive property..
        /// </summary>
        internal static string MustBePrimitiveProperty {
            get {
                return ResourceManager.GetString("MustBePrimitiveProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; must be a primitive type..
        /// </summary>
        internal static string MustBePrimitiveType {
            get {
                return ResourceManager.GetString("MustBePrimitiveType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on type &apos;{1}&apos; must be a System.TimeSpan property..
        /// </summary>
        internal static string MustBeTimeSpanProperty {
            get {
                return ResourceManager.GetString("MustBeTimeSpanProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The multiplicity of the &apos;{0}&apos; property must be &apos;{1}&apos;..
        /// </summary>
        internal static string MustHaveMatchingMultiplicity {
            get {
                return ResourceManager.GetString("MustHaveMatchingMultiplicity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The navigation property binding path &apos;{0}&apos; is not valid. The last segment must be the navigation property &apos;{1}&apos;..
        /// </summary>
        internal static string NavigationPropertyBindingPathIsNotValid {
            get {
                return ResourceManager.GetString("NavigationPropertyBindingPathIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; of the binding type cast segment &apos;{1}&apos; is not a part of the type &apos;{2}&apos; hierarchy..
        /// </summary>
        internal static string NavigationPropertyBindingPathNotInHierarchy {
            get {
                return ResourceManager.GetString("NavigationPropertyBindingPathNotInHierarchy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The navigation property binding path segment &apos;{0}&apos; of member type &apos;{1}&apos; is not supported..
        /// </summary>
        internal static string NavigationPropertyBindingPathNotSupported {
            get {
                return ResourceManager.GetString("NavigationPropertyBindingPathNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The declaring entity type &apos;{0}&apos; of the given navigation property is not a part of the entity type &apos;{1}&apos; hierarchy of the entity set or singleton &apos;{2}&apos;..
        /// </summary>
        internal static string NavigationPropertyNotInHierarchy {
            get {
                return ResourceManager.GetString("NavigationPropertyNotInHierarchy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot define property &apos;{0}&apos; in the base type &apos;{1}&apos; as the derived type &apos;{2}&apos; already defines it..
        /// </summary>
        internal static string PropertyAlreadyDefinedInDerivedType {
            get {
                return ResourceManager.GetString("PropertyAlreadyDefinedInDerivedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; does not belong to the type &apos;{1}&apos;..
        /// </summary>
        internal static string PropertyDoesNotBelongToType {
            get {
                return ResourceManager.GetString("PropertyDoesNotBelongToType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rebinding is not supported..
        /// </summary>
        internal static string RebindingNotSupported {
            get {
                return ResourceManager.GetString("RebindingNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; property &apos;{1}&apos; is already configured to have a relationship with &apos;{2}&apos; property &apos;{3}&apos; in the referential constraint..
        /// </summary>
        internal static string ReferentialConstraintAlreadyConfigured {
            get {
                return ResourceManager.GetString("ReferentialConstraintAlreadyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Referential constraint for navigation property &apos;{0}&apos; on type &apos;{1}&apos; is not supported. Only required or optional navigation properties support referential constraint..
        /// </summary>
        internal static string ReferentialConstraintOnManyNavigationPropertyNotSupported {
            get {
                return ResourceManager.GetString("ReferentialConstraintOnManyNavigationPropertyNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property type &apos;{0}&apos; of the referential constraint is not valid. The referential constraint property type must be primitive type..
        /// </summary>
        internal static string ReferentialConstraintPropertyTypeNotValid {
            get {
                return ResourceManager.GetString("ReferentialConstraintPropertyTypeNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EDM type &apos;{0}&apos; is already declared as an entity type. Use the method &apos;ReturnsCollectionFromEntitySet&apos; if the return type is an entity collection..
        /// </summary>
        internal static string ReturnEntityCollectionWithoutEntitySet {
            get {
                return ResourceManager.GetString("ReturnEntityCollectionWithoutEntitySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EDM type &apos;{0}&apos; is already declared as an entity type. Use the method &apos;ReturnsFromEntitySet&apos; if the return type is an entity..
        /// </summary>
        internal static string ReturnEntityWithoutEntitySet {
            get {
                return ResourceManager.GetString("ReturnEntityWithoutEntitySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The singleton &apos;{0}&apos; was already configured with a different EntityType (&apos;{1}&apos;)..
        /// </summary>
        internal static string SingletonAlreadyConfiguredDifferentEntityType {
            get {
                return ResourceManager.GetString("SingletonAlreadyConfiguredDifferentEntityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The singleton name &apos;{0}&apos; was already configured as an entity set..
        /// </summary>
        internal static string SingletonNameAlreadyConfiguredAsEntitySet {
            get {
                return ResourceManager.GetString("SingletonNameAlreadyConfiguredAsEntitySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be configured as a ComplexType. It was previously configured as an EntityType..
        /// </summary>
        internal static string TypeCannotBeComplexWasEntity {
            get {
                return ResourceManager.GetString("TypeCannotBeComplexWasEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be configured as an EntityType. It was previously configured as a ComplexType..
        /// </summary>
        internal static string TypeCannotBeEntityWasComplex {
            get {
                return ResourceManager.GetString("TypeCannotBeEntityWasComplex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be configured as an enum type..
        /// </summary>
        internal static string TypeCannotBeEnum {
            get {
                return ResourceManager.GetString("TypeCannotBeEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not inherit from &apos;{1}&apos;..
        /// </summary>
        internal static string TypeDoesNotInheritFromBaseType {
            get {
                return ResourceManager.GetString("TypeDoesNotInheritFromBaseType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported Expression NodeType..
        /// </summary>
        internal static string UnsupportedExpressionNodeType {
            get {
                return ResourceManager.GetString("UnsupportedExpressionNodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported Expression NodeType &apos;{0}&apos;..
        /// </summary>
        internal static string UnsupportedExpressionNodeTypeWithName {
            get {
                return ResourceManager.GetString("UnsupportedExpressionNodeTypeWithName", resourceCulture);
            }
        }
    }
}
