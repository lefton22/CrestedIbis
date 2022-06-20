#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF;
// System.Runtime.CompilerServices.CompilerGeneratedAttribute
struct CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C;
// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B;
// System.Reflection.DefaultMemberAttribute
struct DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5;
// System.Runtime.CompilerServices.ExtensionAttribute
struct ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC;
// System.ObsoleteAttribute
struct ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671;
// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80;
// UnityEngine.SerializeField
struct SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25;
// System.String
struct String_t;



IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71  : public RuntimeObject
{
public:

public:
};


// System.String
struct String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Int32 System.Runtime.CompilerServices.CompilationRelaxationsAttribute::m_relaxations
	int32_t ___m_relaxations_0;

public:
	inline static int32_t get_offset_of_m_relaxations_0() { return static_cast<int32_t>(offsetof(CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF, ___m_relaxations_0)); }
	inline int32_t get_m_relaxations_0() const { return ___m_relaxations_0; }
	inline int32_t* get_address_of_m_relaxations_0() { return &___m_relaxations_0; }
	inline void set_m_relaxations_0(int32_t value)
	{
		___m_relaxations_0 = value;
	}
};


// System.Runtime.CompilerServices.CompilerGeneratedAttribute
struct CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Reflection.DefaultMemberAttribute
struct DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.DefaultMemberAttribute::m_memberName
	String_t* ___m_memberName_0;

public:
	inline static int32_t get_offset_of_m_memberName_0() { return static_cast<int32_t>(offsetof(DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5, ___m_memberName_0)); }
	inline String_t* get_m_memberName_0() const { return ___m_memberName_0; }
	inline String_t** get_address_of_m_memberName_0() { return &___m_memberName_0; }
	inline void set_m_memberName_0(String_t* value)
	{
		___m_memberName_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_memberName_0), (void*)value);
	}
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Runtime.CompilerServices.ExtensionAttribute
struct ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.ObsoleteAttribute
struct ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.ObsoleteAttribute::_message
	String_t* ____message_0;
	// System.Boolean System.ObsoleteAttribute::_error
	bool ____error_1;

public:
	inline static int32_t get_offset_of__message_0() { return static_cast<int32_t>(offsetof(ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671, ____message_0)); }
	inline String_t* get__message_0() const { return ____message_0; }
	inline String_t** get_address_of__message_0() { return &____message_0; }
	inline void set__message_0(String_t* value)
	{
		____message_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_0), (void*)value);
	}

	inline static int32_t get_offset_of__error_1() { return static_cast<int32_t>(offsetof(ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671, ____error_1)); }
	inline bool get__error_1() const { return ____error_1; }
	inline bool* get_address_of__error_1() { return &____error_1; }
	inline void set__error_1(bool value)
	{
		____error_1 = value;
	}
};


// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Boolean System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::m_wrapNonExceptionThrows
	bool ___m_wrapNonExceptionThrows_0;

public:
	inline static int32_t get_offset_of_m_wrapNonExceptionThrows_0() { return static_cast<int32_t>(offsetof(RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80, ___m_wrapNonExceptionThrows_0)); }
	inline bool get_m_wrapNonExceptionThrows_0() const { return ___m_wrapNonExceptionThrows_0; }
	inline bool* get_address_of_m_wrapNonExceptionThrows_0() { return &___m_wrapNonExceptionThrows_0; }
	inline void set_m_wrapNonExceptionThrows_0(bool value)
	{
		___m_wrapNonExceptionThrows_0 = value;
	}
};


// UnityEngine.SerializeField
struct SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// System.Diagnostics.DebuggableAttribute/DebuggingModes
struct DebuggingModes_t279D5B9C012ABA935887CB73C5A63A1F46AF08A8 
{
public:
	// System.Int32 System.Diagnostics.DebuggableAttribute/DebuggingModes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DebuggingModes_t279D5B9C012ABA935887CB73C5A63A1F46AF08A8, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Diagnostics.DebuggableAttribute/DebuggingModes System.Diagnostics.DebuggableAttribute::m_debuggingModes
	int32_t ___m_debuggingModes_0;

public:
	inline static int32_t get_offset_of_m_debuggingModes_0() { return static_cast<int32_t>(offsetof(DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B, ___m_debuggingModes_0)); }
	inline int32_t get_m_debuggingModes_0() const { return ___m_debuggingModes_0; }
	inline int32_t* get_address_of_m_debuggingModes_0() { return &___m_debuggingModes_0; }
	inline void set_m_debuggingModes_0(int32_t value)
	{
		___m_debuggingModes_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * __this, int32_t ___relaxations0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::set_WrapNonExceptionThrows(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method);
// System.Void System.Diagnostics.DebuggableAttribute::.ctor(System.Diagnostics.DebuggableAttribute/DebuggingModes)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550 (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * __this, int32_t ___modes0, const RuntimeMethod* method);
// System.Void UnityEngine.SerializeField::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3 (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * __this, const RuntimeMethod* method);
// System.Void System.ObsoleteAttribute::.ctor(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ObsoleteAttribute__ctor_m058D2B798E9AB7E7778A6DB04C3FE7011C660F4C (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * __this, String_t* ___message0, bool ___error1, const RuntimeMethod* method);
// System.Void System.ObsoleteAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ObsoleteAttribute__ctor_mAC32A5CCD287DA84CDA9F08282C1C8B0DB7B9868 (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35 (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * __this, const RuntimeMethod* method);
// System.Void System.Reflection.DefaultMemberAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7 (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * __this, String_t* ___memberName0, const RuntimeMethod* method);
static void AssemblyU2DCSharpU2Dfirstpass_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * tmp = (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF *)cache->attributes[0];
		CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B(tmp, 8LL, NULL);
	}
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[1];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
	{
		RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * tmp = (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 *)cache->attributes[2];
		RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C(tmp, NULL);
		RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline(tmp, true, NULL);
	}
	{
		DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * tmp = (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B *)cache->attributes[3];
		DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550(tmp, 2LL, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__relativeSize(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__size(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__renderFrom(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__renderTo(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__useCustomRenderRange(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__renderLineWidth(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_FindNearestVertex_mB77378363AD5B18A714BE85F1F7B2EA3B5B668E0(CustomAttributesCache* cache)
{
	{
		ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * tmp = (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 *)cache->attributes[0];
		ObsoleteAttribute__ctor_m058D2B798E9AB7E7778A6DB04C3FE7011C660F4C(tmp, il2cpp_codegen_string_new_wrapper("\x44\x65\x70\x72\x65\x63\x61\x74\x65\x64\x2C\x20\x70\x6C\x65\x61\x73\x65\x20\x75\x73\x65\x20\x4E\x65\x61\x72\x65\x73\x74\x56\x65\x72\x74\x65\x78\x57\x20\x69\x6E\x73\x74\x65\x61\x64"), false, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_FindNearestFace_m4DEBDD9699B6C8BCCDE6486D960FF35C85FAEFF9(CustomAttributesCache* cache)
{
	{
		ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * tmp = (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 *)cache->attributes[0];
		ObsoleteAttribute__ctor_mAC32A5CCD287DA84CDA9F08282C1C8B0DB7B9868(tmp, il2cpp_codegen_string_new_wrapper("\x44\x65\x70\x72\x65\x63\x61\x74\x65\x64\x2C\x20\x70\x6C\x65\x61\x73\x65\x20\x75\x73\x65\x20\x4E\x65\x61\x72\x65\x73\x74\x46\x61\x63\x65\x57\x20\x69\x6E\x73\x74\x65\x61\x64"), NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_FindNearestBox_m39C5C0ECED5A5896616D2BD8A1871F8D92900825(CustomAttributesCache* cache)
{
	{
		ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * tmp = (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 *)cache->attributes[0];
		ObsoleteAttribute__ctor_m058D2B798E9AB7E7778A6DB04C3FE7011C660F4C(tmp, il2cpp_codegen_string_new_wrapper("\x44\x65\x70\x72\x65\x63\x61\x74\x65\x64\x2C\x20\x70\x6C\x65\x61\x73\x65\x20\x75\x73\x65\x20\x4E\x65\x61\x72\x65\x73\x74\x42\x6F\x78\x57\x20\x69\x6E\x73\x74\x65\x61\x64"), false, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_GetVertexCoordinates_mB8B807D73DC394E9C712FC787B9731E0A5A2FB2C(CustomAttributesCache* cache)
{
	{
		ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * tmp = (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 *)cache->attributes[0];
		ObsoleteAttribute__ctor_m058D2B798E9AB7E7778A6DB04C3FE7011C660F4C(tmp, il2cpp_codegen_string_new_wrapper("\x44\x65\x70\x72\x65\x63\x61\x74\x65\x64\x2C\x20\x70\x6C\x65\x61\x73\x65\x20\x75\x73\x65\x20\x4E\x65\x61\x72\x65\x73\x74\x56\x65\x72\x74\x65\x78\x47\x20\x69\x6E\x73\x74\x65\x61\x64"), false, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_GetFaceCoordinates_mF6D22844EF6123C422C6B91B2CFD4BD449E3B0ED(CustomAttributesCache* cache)
{
	{
		ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * tmp = (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 *)cache->attributes[0];
		ObsoleteAttribute__ctor_m058D2B798E9AB7E7778A6DB04C3FE7011C660F4C(tmp, il2cpp_codegen_string_new_wrapper("\x44\x65\x70\x72\x65\x63\x61\x74\x65\x64\x2C\x20\x70\x6C\x65\x61\x73\x65\x20\x75\x73\x65\x20\x4E\x65\x61\x72\x65\x73\x74\x46\x61\x63\x65\x47\x20\x69\x6E\x73\x74\x65\x61\x64"), false, NULL);
	}
}
static void GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_GetBoxCoordinates_m4C5AC0B469A911F7512B0F935029784E791B5196(CustomAttributesCache* cache)
{
	{
		ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 * tmp = (ObsoleteAttribute_t14BAC1669C0409EB9F28D72D664FFA6764ACD671 *)cache->attributes[0];
		ObsoleteAttribute__ctor_m058D2B798E9AB7E7778A6DB04C3FE7011C660F4C(tmp, il2cpp_codegen_string_new_wrapper("\x44\x65\x70\x72\x65\x63\x61\x74\x65\x64\x2C\x20\x70\x6C\x65\x61\x73\x65\x20\x75\x73\x65\x20\x4E\x65\x61\x72\x65\x73\x74\x42\x6F\x78\x47\x20\x69\x6E\x73\x74\x65\x61\x64"), false, NULL);
	}
}
static void U3CU3Ec_tF59517922A17D22AEB3CFF9152AE8E296236A923_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void GFLayeredGrid_tA0CF6105FB51D2F8ACD7B01E09FF0FB15EBD903C_CustomAttributesCacheGenerator__depth(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFLayeredGrid_tA0CF6105FB51D2F8ACD7B01E09FF0FB15EBD903C_CustomAttributesCacheGenerator__gridPlane(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFTransformExtensions_tB150ADFBE2F2BA86697DB36258ABEAB9B1BBC6B1_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFTransformExtensions_tB150ADFBE2F2BA86697DB36258ABEAB9B1BBC6B1_CustomAttributesCacheGenerator_GFTransformExtensions_GFTransformPointFixed_mDA6F6D4CDE51E96F376662BFC7DC0C07089AD5A3(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFTransformExtensions_tB150ADFBE2F2BA86697DB36258ABEAB9B1BBC6B1_CustomAttributesCacheGenerator_GFTransformExtensions_GFInverseTransformPointFixed_mEC3EDA44395EFC6E0DF570F765999580F31EE573(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFReverseScale_m82A5D33A9CAFB481E198A33CF0483888DD323919(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFModulo_mC5DD5B50EBF6B514FAA555EA12DB5A4B7B7FD13D(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFModulo3_m7B5DFD04897062891087E3EDFECC2139D917175B(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFAbs_mBD7CF5A897A1C19A5B731FB27CF7AF4B28F243DB(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFSign_m692869B6F639CCE7BAAE2632D467D1A9309F0A90(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorTwoExtensions_tA871956CBE63144A316C854272BAD884A730DBA8_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFVectorTwoExtensions_tA871956CBE63144A316C854272BAD884A730DBA8_CustomAttributesCacheGenerator_GFVectorTwoExtensions_GFConjugate_m0792FCDD77C4DF317CD1B0A11BE22906F66E25AC(CustomAttributesCache* cache)
{
	{
		ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC * tmp = (ExtensionAttribute_t917F3F92E717DC8B2D7BC03967A9790B1B8EF7CC *)cache->attributes[0];
		ExtensionAttribute__ctor_mB331519C39C4210259A248A4C629DF934937C1FA(tmp, NULL);
	}
}
static void GFHexGrid_t37DAF789BABD6122050CA71573A9245C1F05EE19_CustomAttributesCacheGenerator__radius(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFHexGrid_t37DAF789BABD6122050CA71573A9245C1F05EE19_CustomAttributesCacheGenerator__hexSideMode(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFHexGrid_t37DAF789BABD6122050CA71573A9245C1F05EE19_CustomAttributesCacheGenerator__gridStyle(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFPolarGrid_t9CEBF984B455537B97EA8668EDA481ECD4AC13A6_CustomAttributesCacheGenerator__radius(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFPolarGrid_t9CEBF984B455537B97EA8668EDA481ECD4AC13A6_CustomAttributesCacheGenerator__sectors(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFPolarGrid_t9CEBF984B455537B97EA8668EDA481ECD4AC13A6_CustomAttributesCacheGenerator__smoothness(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFRectGrid_tD945EEC20B8B86A41E3A1A983EF5679F44BAEE52_CustomAttributesCacheGenerator__spacing(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void GFBoolVector3_t2847B00F7891AB008EE6FE4A1A71CA56ABC9E235_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void GFColorVector3_t8AA6E9DCBA1875BD7A4662958820CF7BF8522D97_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
IL2CPP_EXTERN_C const CustomAttributesCacheGenerator g_AssemblyU2DCSharpU2Dfirstpass_AttributeGenerators[];
const CustomAttributesCacheGenerator g_AssemblyU2DCSharpU2Dfirstpass_AttributeGenerators[36] = 
{
	U3CU3Ec_tF59517922A17D22AEB3CFF9152AE8E296236A923_CustomAttributesCacheGenerator,
	GFTransformExtensions_tB150ADFBE2F2BA86697DB36258ABEAB9B1BBC6B1_CustomAttributesCacheGenerator,
	GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator,
	GFVectorTwoExtensions_tA871956CBE63144A316C854272BAD884A730DBA8_CustomAttributesCacheGenerator,
	GFBoolVector3_t2847B00F7891AB008EE6FE4A1A71CA56ABC9E235_CustomAttributesCacheGenerator,
	GFColorVector3_t8AA6E9DCBA1875BD7A4662958820CF7BF8522D97_CustomAttributesCacheGenerator,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__relativeSize,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__size,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__renderFrom,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__renderTo,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__useCustomRenderRange,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator__renderLineWidth,
	GFLayeredGrid_tA0CF6105FB51D2F8ACD7B01E09FF0FB15EBD903C_CustomAttributesCacheGenerator__depth,
	GFLayeredGrid_tA0CF6105FB51D2F8ACD7B01E09FF0FB15EBD903C_CustomAttributesCacheGenerator__gridPlane,
	GFHexGrid_t37DAF789BABD6122050CA71573A9245C1F05EE19_CustomAttributesCacheGenerator__radius,
	GFHexGrid_t37DAF789BABD6122050CA71573A9245C1F05EE19_CustomAttributesCacheGenerator__hexSideMode,
	GFHexGrid_t37DAF789BABD6122050CA71573A9245C1F05EE19_CustomAttributesCacheGenerator__gridStyle,
	GFPolarGrid_t9CEBF984B455537B97EA8668EDA481ECD4AC13A6_CustomAttributesCacheGenerator__radius,
	GFPolarGrid_t9CEBF984B455537B97EA8668EDA481ECD4AC13A6_CustomAttributesCacheGenerator__sectors,
	GFPolarGrid_t9CEBF984B455537B97EA8668EDA481ECD4AC13A6_CustomAttributesCacheGenerator__smoothness,
	GFRectGrid_tD945EEC20B8B86A41E3A1A983EF5679F44BAEE52_CustomAttributesCacheGenerator__spacing,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_FindNearestVertex_mB77378363AD5B18A714BE85F1F7B2EA3B5B668E0,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_FindNearestFace_m4DEBDD9699B6C8BCCDE6486D960FF35C85FAEFF9,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_FindNearestBox_m39C5C0ECED5A5896616D2BD8A1871F8D92900825,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_GetVertexCoordinates_mB8B807D73DC394E9C712FC787B9731E0A5A2FB2C,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_GetFaceCoordinates_mF6D22844EF6123C422C6B91B2CFD4BD449E3B0ED,
	GFGrid_tD5741D29E78705E57D714C7D55BB9A9AE3B57999_CustomAttributesCacheGenerator_GFGrid_GetBoxCoordinates_m4C5AC0B469A911F7512B0F935029784E791B5196,
	GFTransformExtensions_tB150ADFBE2F2BA86697DB36258ABEAB9B1BBC6B1_CustomAttributesCacheGenerator_GFTransformExtensions_GFTransformPointFixed_mDA6F6D4CDE51E96F376662BFC7DC0C07089AD5A3,
	GFTransformExtensions_tB150ADFBE2F2BA86697DB36258ABEAB9B1BBC6B1_CustomAttributesCacheGenerator_GFTransformExtensions_GFInverseTransformPointFixed_mEC3EDA44395EFC6E0DF570F765999580F31EE573,
	GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFReverseScale_m82A5D33A9CAFB481E198A33CF0483888DD323919,
	GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFModulo_mC5DD5B50EBF6B514FAA555EA12DB5A4B7B7FD13D,
	GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFModulo3_m7B5DFD04897062891087E3EDFECC2139D917175B,
	GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFAbs_mBD7CF5A897A1C19A5B731FB27CF7AF4B28F243DB,
	GFVectorThreeExtensions_t409B593BA42B2A031AB3D13858638A840F764436_CustomAttributesCacheGenerator_GFVectorThreeExtensions_GFSign_m692869B6F639CCE7BAAE2632D467D1A9309F0A90,
	GFVectorTwoExtensions_tA871956CBE63144A316C854272BAD884A730DBA8_CustomAttributesCacheGenerator_GFVectorTwoExtensions_GFConjugate_m0792FCDD77C4DF317CD1B0A11BE22906F66E25AC,
	AssemblyU2DCSharpU2Dfirstpass_CustomAttributesCacheGenerator,
};
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_m_wrapNonExceptionThrows_0(L_0);
		return;
	}
}
