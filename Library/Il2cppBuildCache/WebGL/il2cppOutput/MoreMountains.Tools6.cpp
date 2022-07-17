#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct GenericVirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.NotSupportedException
struct NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.String
struct String_t;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013;
// MoreMountains.Tools.MMDebug/DebugLogItem
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06;
// MoreMountains.Tools.MMTween/<MoveTransformCo>d__18
struct U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41;
// MoreMountains.Tools.MMTween/<MoveTransformCo>d__19
struct U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F;
// MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20
struct U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14;
// MoreMountains.Tools.MMDebug/MMDebugLogEvent/Delegate
struct Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59;
// MoreMountains.Tools.MMInput/IMButton/ButtonDownMethodDelegate
struct ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705;
// MoreMountains.Tools.MMInput/IMButton/ButtonPressedMethodDelegate
struct ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B;
// MoreMountains.Tools.MMInput/IMButton/ButtonUpMethodDelegate
struct ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C;

IL2CPP_EXTERN_C RuntimeClass* DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CMoveTransformCoU3Ed__18_System_Collections_IEnumerator_Reset_m1437A932F8A0493E283C42D4F82D0C5F781C869E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CMoveTransformCoU3Ed__19_System_Collections_IEnumerator_Reset_mEB44C68F9A8677925955B3DADCC976CD6B96B77F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CRotateTransformAroundCoU3Ed__20_System_Collections_IEnumerator_Reset_mB4AB4E0ADA3CA0EE323503337E886B41DA95627E_RuntimeMethod_var;
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06;;
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke;
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke;;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

struct Il2CppArrayBounds;

// System.Array


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

// UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com
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

// System.Int32
struct Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// UnityEngine.Quaternion
struct Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 
{
public:
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}

	inline static int32_t get_offset_of_z_2() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___z_2)); }
	inline float get_z_2() const { return ___z_2; }
	inline float* get_address_of_z_2() { return &___z_2; }
	inline void set_z_2(float value)
	{
		___z_2 = value;
	}

	inline static int32_t get_offset_of_w_3() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___w_3)); }
	inline float get_w_3() const { return ___w_3; }
	inline float* get_address_of_w_3() { return &___w_3; }
	inline void set_w_3(float value)
	{
		___w_3 = value;
	}
};

struct Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4_StaticFields
{
public:
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___identityQuaternion_4;

public:
	inline static int32_t get_offset_of_identityQuaternion_4() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4_StaticFields, ___identityQuaternion_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_identityQuaternion_4() const { return ___identityQuaternion_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_identityQuaternion_4() { return &___identityQuaternion_4; }
	inline void set_identityQuaternion_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___identityQuaternion_4 = value;
	}
};


// System.Single
struct Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// UnityEngine.Vector3
struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___zeroVector_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___oneVector_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___upVector_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___downVector_8)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___leftVector_9)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___rightVector_10)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___forwardVector_11)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___backVector_12)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___negativeInfinityVector_14 = value;
	}
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


// UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013  : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF
{
public:
	// System.Single UnityEngine.WaitForSeconds::m_Seconds
	float ___m_Seconds_0;

public:
	inline static int32_t get_offset_of_m_Seconds_0() { return static_cast<int32_t>(offsetof(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013, ___m_Seconds_0)); }
	inline float get_m_Seconds_0() const { return ___m_Seconds_0; }
	inline float* get_address_of_m_Seconds_0() { return &___m_Seconds_0; }
	inline void set_m_Seconds_0(float value)
	{
		___m_Seconds_0 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_pinvoke : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke
{
	float ___m_Seconds_0;
};
// Native definition for COM marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_com : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com
{
	float ___m_Seconds_0;
};

// MoreMountains.Tools.MMDebug/DebugLogItem
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06 
{
public:
	// System.Object MoreMountains.Tools.MMDebug/DebugLogItem::Message
	RuntimeObject * ___Message_0;
	// System.String MoreMountains.Tools.MMDebug/DebugLogItem::Color
	String_t* ___Color_1;
	// System.Int32 MoreMountains.Tools.MMDebug/DebugLogItem::Framecount
	int32_t ___Framecount_2;
	// System.Single MoreMountains.Tools.MMDebug/DebugLogItem::Time
	float ___Time_3;
	// System.Int32 MoreMountains.Tools.MMDebug/DebugLogItem::TimePrecision
	int32_t ___TimePrecision_4;
	// System.Boolean MoreMountains.Tools.MMDebug/DebugLogItem::DisplayFrameCount
	bool ___DisplayFrameCount_5;

public:
	inline static int32_t get_offset_of_Message_0() { return static_cast<int32_t>(offsetof(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06, ___Message_0)); }
	inline RuntimeObject * get_Message_0() const { return ___Message_0; }
	inline RuntimeObject ** get_address_of_Message_0() { return &___Message_0; }
	inline void set_Message_0(RuntimeObject * value)
	{
		___Message_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Message_0), (void*)value);
	}

	inline static int32_t get_offset_of_Color_1() { return static_cast<int32_t>(offsetof(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06, ___Color_1)); }
	inline String_t* get_Color_1() const { return ___Color_1; }
	inline String_t** get_address_of_Color_1() { return &___Color_1; }
	inline void set_Color_1(String_t* value)
	{
		___Color_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Color_1), (void*)value);
	}

	inline static int32_t get_offset_of_Framecount_2() { return static_cast<int32_t>(offsetof(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06, ___Framecount_2)); }
	inline int32_t get_Framecount_2() const { return ___Framecount_2; }
	inline int32_t* get_address_of_Framecount_2() { return &___Framecount_2; }
	inline void set_Framecount_2(int32_t value)
	{
		___Framecount_2 = value;
	}

	inline static int32_t get_offset_of_Time_3() { return static_cast<int32_t>(offsetof(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06, ___Time_3)); }
	inline float get_Time_3() const { return ___Time_3; }
	inline float* get_address_of_Time_3() { return &___Time_3; }
	inline void set_Time_3(float value)
	{
		___Time_3 = value;
	}

	inline static int32_t get_offset_of_TimePrecision_4() { return static_cast<int32_t>(offsetof(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06, ___TimePrecision_4)); }
	inline int32_t get_TimePrecision_4() const { return ___TimePrecision_4; }
	inline int32_t* get_address_of_TimePrecision_4() { return &___TimePrecision_4; }
	inline void set_TimePrecision_4(int32_t value)
	{
		___TimePrecision_4 = value;
	}

	inline static int32_t get_offset_of_DisplayFrameCount_5() { return static_cast<int32_t>(offsetof(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06, ___DisplayFrameCount_5)); }
	inline bool get_DisplayFrameCount_5() const { return ___DisplayFrameCount_5; }
	inline bool* get_address_of_DisplayFrameCount_5() { return &___DisplayFrameCount_5; }
	inline void set_DisplayFrameCount_5(bool value)
	{
		___DisplayFrameCount_5 = value;
	}
};

// Native definition for P/Invoke marshalling of MoreMountains.Tools.MMDebug/DebugLogItem
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke
{
	Il2CppIUnknown* ___Message_0;
	char* ___Color_1;
	int32_t ___Framecount_2;
	float ___Time_3;
	int32_t ___TimePrecision_4;
	int32_t ___DisplayFrameCount_5;
};
// Native definition for COM marshalling of MoreMountains.Tools.MMDebug/DebugLogItem
struct DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_com
{
	Il2CppIUnknown* ___Message_0;
	Il2CppChar* ___Color_1;
	int32_t ___Framecount_2;
	float ___Time_3;
	int32_t ___TimePrecision_4;
	int32_t ___DisplayFrameCount_5;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_target_2), (void*)value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_info_7), (void*)value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___original_method_info_8), (void*)value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * get_data_9() const { return ___data_9; }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_9), (void*)value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____className_1), (void*)value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_2), (void*)value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____data_3), (void*)value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerException_4), (void*)value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____helpURL_5), (void*)value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTrace_6), (void*)value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTraceString_7), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____remoteStackTraceString_8), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dynamicMethods_10), (void*)value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_12), (void*)value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____safeSerializationManager_13), (void*)value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___captured_traces_14), (void*)value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_trace_ips_15), (void*)value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_EDILock_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};

// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// MoreMountains.Tools.MMTween/MMTweenCurve
struct MMTweenCurve_tC880A885C5B5976B67879343E813427B2CF5DD24 
{
public:
	// System.Int32 MoreMountains.Tools.MMTween/MMTweenCurve::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MMTweenCurve_tC880A885C5B5976B67879343E813427B2CF5DD24, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// MoreMountains.Tools.MMTwoSidedUI/Axis
struct Axis_t78A098EB4A8B14A6FEAB4121E7C3D2E1BBE7852D 
{
public:
	// System.Int32 MoreMountains.Tools.MMTwoSidedUI/Axis::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Axis_t78A098EB4A8B14A6FEAB4121E7C3D2E1BBE7852D, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// MoreMountains.Tools.MonoAttribute/MemberTypes
struct MemberTypes_tF66AC47B64075D894FC0D30290055A7C10050390 
{
public:
	// System.Int32 MoreMountains.Tools.MonoAttribute/MemberTypes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MemberTypes_tF66AC47B64075D894FC0D30290055A7C10050390, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// MoreMountains.Tools.PlatformBindings/PlatformActions
struct PlatformActions_t4A16A884EB945CE9E7B754432A04D2F47E169F6F 
{
public:
	// System.Int32 MoreMountains.Tools.PlatformBindings/PlatformActions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PlatformActions_t4A16A884EB945CE9E7B754432A04D2F47E169F6F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// MoreMountains.Tools.ShaderController/ControlModes
struct ControlModes_tF0B3D892758019C5B1ED7BB9F4363F47A68C0E72 
{
public:
	// System.Int32 MoreMountains.Tools.ShaderController/ControlModes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ControlModes_tF0B3D892758019C5B1ED7BB9F4363F47A68C0E72, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// MoreMountains.Tools.ShaderController/PropertyTypes
struct PropertyTypes_t84B4C4D38EBDBC111202D6DEE74336DD326A2FFC 
{
public:
	// System.Int32 MoreMountains.Tools.ShaderController/PropertyTypes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PropertyTypes_t84B4C4D38EBDBC111202D6DEE74336DD326A2FFC, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// MoreMountains.Tools.ShaderController/TargetTypes
struct TargetTypes_t8E3008201FBE25CA4F88A9A29FFBDE8555B74D72 
{
public:
	// System.Int32 MoreMountains.Tools.ShaderController/TargetTypes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TargetTypes_t8E3008201FBE25CA4F88A9A29FFBDE8555B74D72, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_11), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};

// System.SystemException
struct SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
};


// MoreMountains.Tools.MMTween/<MoveTransformCo>d__18
struct U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41  : public RuntimeObject
{
public:
	// System.Int32 MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// System.Single MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::delayDuration
	float ___delayDuration_2;
	// UnityEngine.WaitForSeconds MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::delay
	WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * ___delay_3;
	// System.Single MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::duration
	float ___duration_4;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::targetTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___targetTransform_5;
	// UnityEngine.Vector3 MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::origin
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___origin_6;
	// UnityEngine.Vector3 MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::destination
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___destination_7;
	// MoreMountains.Tools.MMTween/MMTweenCurve MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::curve
	int32_t ___curve_8;
	// System.Boolean MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::ignoreTimescale
	bool ___ignoreTimescale_9;
	// System.Single MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::<timeLeft>5__2
	float ___U3CtimeLeftU3E5__2_10;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_delayDuration_2() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___delayDuration_2)); }
	inline float get_delayDuration_2() const { return ___delayDuration_2; }
	inline float* get_address_of_delayDuration_2() { return &___delayDuration_2; }
	inline void set_delayDuration_2(float value)
	{
		___delayDuration_2 = value;
	}

	inline static int32_t get_offset_of_delay_3() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___delay_3)); }
	inline WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * get_delay_3() const { return ___delay_3; }
	inline WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 ** get_address_of_delay_3() { return &___delay_3; }
	inline void set_delay_3(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * value)
	{
		___delay_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delay_3), (void*)value);
	}

	inline static int32_t get_offset_of_duration_4() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___duration_4)); }
	inline float get_duration_4() const { return ___duration_4; }
	inline float* get_address_of_duration_4() { return &___duration_4; }
	inline void set_duration_4(float value)
	{
		___duration_4 = value;
	}

	inline static int32_t get_offset_of_targetTransform_5() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___targetTransform_5)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_targetTransform_5() const { return ___targetTransform_5; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_targetTransform_5() { return &___targetTransform_5; }
	inline void set_targetTransform_5(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___targetTransform_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetTransform_5), (void*)value);
	}

	inline static int32_t get_offset_of_origin_6() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___origin_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_origin_6() const { return ___origin_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_origin_6() { return &___origin_6; }
	inline void set_origin_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___origin_6 = value;
	}

	inline static int32_t get_offset_of_destination_7() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___destination_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_destination_7() const { return ___destination_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_destination_7() { return &___destination_7; }
	inline void set_destination_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___destination_7 = value;
	}

	inline static int32_t get_offset_of_curve_8() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___curve_8)); }
	inline int32_t get_curve_8() const { return ___curve_8; }
	inline int32_t* get_address_of_curve_8() { return &___curve_8; }
	inline void set_curve_8(int32_t value)
	{
		___curve_8 = value;
	}

	inline static int32_t get_offset_of_ignoreTimescale_9() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___ignoreTimescale_9)); }
	inline bool get_ignoreTimescale_9() const { return ___ignoreTimescale_9; }
	inline bool* get_address_of_ignoreTimescale_9() { return &___ignoreTimescale_9; }
	inline void set_ignoreTimescale_9(bool value)
	{
		___ignoreTimescale_9 = value;
	}

	inline static int32_t get_offset_of_U3CtimeLeftU3E5__2_10() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41, ___U3CtimeLeftU3E5__2_10)); }
	inline float get_U3CtimeLeftU3E5__2_10() const { return ___U3CtimeLeftU3E5__2_10; }
	inline float* get_address_of_U3CtimeLeftU3E5__2_10() { return &___U3CtimeLeftU3E5__2_10; }
	inline void set_U3CtimeLeftU3E5__2_10(float value)
	{
		___U3CtimeLeftU3E5__2_10 = value;
	}
};


// MoreMountains.Tools.MMTween/<MoveTransformCo>d__19
struct U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F  : public RuntimeObject
{
public:
	// System.Int32 MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// System.Single MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::delayDuration
	float ___delayDuration_2;
	// UnityEngine.WaitForSeconds MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::delay
	WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * ___delay_3;
	// System.Single MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::duration
	float ___duration_4;
	// System.Boolean MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::updatePosition
	bool ___updatePosition_5;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::targetTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___targetTransform_6;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::origin
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___origin_7;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::destination
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___destination_8;
	// MoreMountains.Tools.MMTween/MMTweenCurve MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::curve
	int32_t ___curve_9;
	// System.Boolean MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::updateRotation
	bool ___updateRotation_10;
	// System.Boolean MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::ignoreTimescale
	bool ___ignoreTimescale_11;
	// System.Single MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::<timeLeft>5__2
	float ___U3CtimeLeftU3E5__2_12;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_delayDuration_2() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___delayDuration_2)); }
	inline float get_delayDuration_2() const { return ___delayDuration_2; }
	inline float* get_address_of_delayDuration_2() { return &___delayDuration_2; }
	inline void set_delayDuration_2(float value)
	{
		___delayDuration_2 = value;
	}

	inline static int32_t get_offset_of_delay_3() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___delay_3)); }
	inline WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * get_delay_3() const { return ___delay_3; }
	inline WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 ** get_address_of_delay_3() { return &___delay_3; }
	inline void set_delay_3(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * value)
	{
		___delay_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delay_3), (void*)value);
	}

	inline static int32_t get_offset_of_duration_4() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___duration_4)); }
	inline float get_duration_4() const { return ___duration_4; }
	inline float* get_address_of_duration_4() { return &___duration_4; }
	inline void set_duration_4(float value)
	{
		___duration_4 = value;
	}

	inline static int32_t get_offset_of_updatePosition_5() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___updatePosition_5)); }
	inline bool get_updatePosition_5() const { return ___updatePosition_5; }
	inline bool* get_address_of_updatePosition_5() { return &___updatePosition_5; }
	inline void set_updatePosition_5(bool value)
	{
		___updatePosition_5 = value;
	}

	inline static int32_t get_offset_of_targetTransform_6() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___targetTransform_6)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_targetTransform_6() const { return ___targetTransform_6; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_targetTransform_6() { return &___targetTransform_6; }
	inline void set_targetTransform_6(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___targetTransform_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetTransform_6), (void*)value);
	}

	inline static int32_t get_offset_of_origin_7() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___origin_7)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_origin_7() const { return ___origin_7; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_origin_7() { return &___origin_7; }
	inline void set_origin_7(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___origin_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___origin_7), (void*)value);
	}

	inline static int32_t get_offset_of_destination_8() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___destination_8)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_destination_8() const { return ___destination_8; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_destination_8() { return &___destination_8; }
	inline void set_destination_8(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___destination_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___destination_8), (void*)value);
	}

	inline static int32_t get_offset_of_curve_9() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___curve_9)); }
	inline int32_t get_curve_9() const { return ___curve_9; }
	inline int32_t* get_address_of_curve_9() { return &___curve_9; }
	inline void set_curve_9(int32_t value)
	{
		___curve_9 = value;
	}

	inline static int32_t get_offset_of_updateRotation_10() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___updateRotation_10)); }
	inline bool get_updateRotation_10() const { return ___updateRotation_10; }
	inline bool* get_address_of_updateRotation_10() { return &___updateRotation_10; }
	inline void set_updateRotation_10(bool value)
	{
		___updateRotation_10 = value;
	}

	inline static int32_t get_offset_of_ignoreTimescale_11() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___ignoreTimescale_11)); }
	inline bool get_ignoreTimescale_11() const { return ___ignoreTimescale_11; }
	inline bool* get_address_of_ignoreTimescale_11() { return &___ignoreTimescale_11; }
	inline void set_ignoreTimescale_11(bool value)
	{
		___ignoreTimescale_11 = value;
	}

	inline static int32_t get_offset_of_U3CtimeLeftU3E5__2_12() { return static_cast<int32_t>(offsetof(U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F, ___U3CtimeLeftU3E5__2_12)); }
	inline float get_U3CtimeLeftU3E5__2_12() const { return ___U3CtimeLeftU3E5__2_12; }
	inline float* get_address_of_U3CtimeLeftU3E5__2_12() { return &___U3CtimeLeftU3E5__2_12; }
	inline void set_U3CtimeLeftU3E5__2_12(float value)
	{
		___U3CtimeLeftU3E5__2_12 = value;
	}
};


// MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20
struct U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14  : public RuntimeObject
{
public:
	// System.Int32 MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// System.Single MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::delayDuration
	float ___delayDuration_2;
	// UnityEngine.WaitForSeconds MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::delay
	WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * ___delay_3;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::targetTransform
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___targetTransform_4;
	// System.Single MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::duration
	float ___duration_5;
	// System.Single MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::angle
	float ___angle_6;
	// MoreMountains.Tools.MMTween/MMTweenCurve MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::curve
	int32_t ___curve_7;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::center
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___center_8;
	// System.Boolean MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::ignoreTimescale
	bool ___ignoreTimescale_9;
	// UnityEngine.Transform MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::destination
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___destination_10;
	// UnityEngine.Vector3 MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::<initialRotationPosition>5__2
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___U3CinitialRotationPositionU3E5__2_11;
	// System.Single MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::<timeSpent>5__3
	float ___U3CtimeSpentU3E5__3_12;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_delayDuration_2() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___delayDuration_2)); }
	inline float get_delayDuration_2() const { return ___delayDuration_2; }
	inline float* get_address_of_delayDuration_2() { return &___delayDuration_2; }
	inline void set_delayDuration_2(float value)
	{
		___delayDuration_2 = value;
	}

	inline static int32_t get_offset_of_delay_3() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___delay_3)); }
	inline WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * get_delay_3() const { return ___delay_3; }
	inline WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 ** get_address_of_delay_3() { return &___delay_3; }
	inline void set_delay_3(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * value)
	{
		___delay_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delay_3), (void*)value);
	}

	inline static int32_t get_offset_of_targetTransform_4() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___targetTransform_4)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_targetTransform_4() const { return ___targetTransform_4; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_targetTransform_4() { return &___targetTransform_4; }
	inline void set_targetTransform_4(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___targetTransform_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetTransform_4), (void*)value);
	}

	inline static int32_t get_offset_of_duration_5() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___duration_5)); }
	inline float get_duration_5() const { return ___duration_5; }
	inline float* get_address_of_duration_5() { return &___duration_5; }
	inline void set_duration_5(float value)
	{
		___duration_5 = value;
	}

	inline static int32_t get_offset_of_angle_6() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___angle_6)); }
	inline float get_angle_6() const { return ___angle_6; }
	inline float* get_address_of_angle_6() { return &___angle_6; }
	inline void set_angle_6(float value)
	{
		___angle_6 = value;
	}

	inline static int32_t get_offset_of_curve_7() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___curve_7)); }
	inline int32_t get_curve_7() const { return ___curve_7; }
	inline int32_t* get_address_of_curve_7() { return &___curve_7; }
	inline void set_curve_7(int32_t value)
	{
		___curve_7 = value;
	}

	inline static int32_t get_offset_of_center_8() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___center_8)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_center_8() const { return ___center_8; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_center_8() { return &___center_8; }
	inline void set_center_8(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___center_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___center_8), (void*)value);
	}

	inline static int32_t get_offset_of_ignoreTimescale_9() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___ignoreTimescale_9)); }
	inline bool get_ignoreTimescale_9() const { return ___ignoreTimescale_9; }
	inline bool* get_address_of_ignoreTimescale_9() { return &___ignoreTimescale_9; }
	inline void set_ignoreTimescale_9(bool value)
	{
		___ignoreTimescale_9 = value;
	}

	inline static int32_t get_offset_of_destination_10() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___destination_10)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_destination_10() const { return ___destination_10; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_destination_10() { return &___destination_10; }
	inline void set_destination_10(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___destination_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___destination_10), (void*)value);
	}

	inline static int32_t get_offset_of_U3CinitialRotationPositionU3E5__2_11() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___U3CinitialRotationPositionU3E5__2_11)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_U3CinitialRotationPositionU3E5__2_11() const { return ___U3CinitialRotationPositionU3E5__2_11; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_U3CinitialRotationPositionU3E5__2_11() { return &___U3CinitialRotationPositionU3E5__2_11; }
	inline void set_U3CinitialRotationPositionU3E5__2_11(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___U3CinitialRotationPositionU3E5__2_11 = value;
	}

	inline static int32_t get_offset_of_U3CtimeSpentU3E5__3_12() { return static_cast<int32_t>(offsetof(U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14, ___U3CtimeSpentU3E5__3_12)); }
	inline float get_U3CtimeSpentU3E5__3_12() const { return ___U3CtimeSpentU3E5__3_12; }
	inline float* get_address_of_U3CtimeSpentU3E5__3_12() { return &___U3CtimeSpentU3E5__3_12; }
	inline void set_U3CtimeSpentU3E5__3_12(float value)
	{
		___U3CtimeSpentU3E5__3_12 = value;
	}
};


// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA  : public MulticastDelegate_t
{
public:

public:
};


// System.NotSupportedException
struct NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// MoreMountains.Tools.MMDebug/MMDebugLogEvent/Delegate
struct Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59  : public MulticastDelegate_t
{
public:

public:
};


// MoreMountains.Tools.MMInput/IMButton/ButtonDownMethodDelegate
struct ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705  : public MulticastDelegate_t
{
public:

public:
};


// MoreMountains.Tools.MMInput/IMButton/ButtonPressedMethodDelegate
struct ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B  : public MulticastDelegate_t
{
public:

public:
};


// MoreMountains.Tools.MMInput/IMButton/ButtonUpMethodDelegate
struct ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Delegate_t * m_Items[1];

public:
	inline Delegate_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};

IL2CPP_EXTERN_C void DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshal_pinvoke(const DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06& unmarshaled, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshal_pinvoke_back(const DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke& marshaled, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06& unmarshaled);
IL2CPP_EXTERN_C void DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshal_pinvoke_cleanup(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke& marshaled);


// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 MoreMountains.Tools.MMTween::Tween(System.Single,System.Single,System.Single,UnityEngine.Vector3,UnityEngine.Vector3,MoreMountains.Tools.MMTween/MMTweenCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  MMTween_Tween_m2BDC8328BE236482F235949CE01A9CE2118CA21E (float ___currentTime0, float ___initialTime1, float ___endTime2, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___startValue3, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___endValue4, int32_t ___curve5, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_deltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290 (const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_unscaledDeltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84 (const RuntimeMethod* method);
// System.Void System.NotSupportedException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// UnityEngine.Quaternion MoreMountains.Tools.MMTween::Tween(System.Single,System.Single,System.Single,UnityEngine.Quaternion,UnityEngine.Quaternion,MoreMountains.Tools.MMTween/MMTweenCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  MMTween_Tween_mF03B1E6E05B524C61DED95B33F1E3C968C4513F5 (float ___currentTime0, float ___initialTime1, float ___endTime2, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___startValue3, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___endValue4, int32_t ___curve5, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_rotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_rotation_m1B5F3D4CE984AB31254615C9C71B0E54978583B4 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_localEulerAngles()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_localEulerAngles_m4C442107F523737ADAB54855FDC1777A9B71D545 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localEulerAngles(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localEulerAngles_mB63076996124DC76E6902A81677A6E3C814C693B (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Single MoreMountains.Tools.MMTween::Tween(System.Single,System.Single,System.Single,System.Single,System.Single,MoreMountains.Tools.MMTween/MMTweenCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float MMTween_Tween_m5DDB8ECB3E521801BF6A78B65C55B14E5FA7A959 (float ___currentTime0, float ___initialTime1, float ___endTime2, float ___startValue3, float ___endValue4, int32_t ___curve5, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_up()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_up_mAB753D250A30C78924D5D22B0821F1D254525C31 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::RotateAround(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_RotateAround_m1F93A7A1807BE407BD23EC1BA49F03AD22FCE4BE (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___point0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___axis1, float ___angle2, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CMoveTransformCoU3Ed__18__ctor_mE1C91B15A3DEBBB2F65899DAD16DB149DF7807A3 (U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CMoveTransformCoU3Ed__18_System_IDisposable_Dispose_m5F876E9671A750DC1E5ED510D46672182D66E18E (U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CMoveTransformCoU3Ed__18_MoveNext_m1042A579757654FD891536A5EF042C1FBB90F930 (U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	float G_B8_0 = 0.0f;
	U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * G_B8_1 = NULL;
	float G_B7_0 = 0.0f;
	U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * G_B7_1 = NULL;
	float G_B9_0 = 0.0f;
	float G_B9_1 = 0.0f;
	U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * G_B9_2 = NULL;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		int32_t L_1 = V_0;
		switch (L_1)
		{
			case 0:
			{
				goto IL_001b;
			}
			case 1:
			{
				goto IL_0044;
			}
			case 2:
			{
				goto IL_00c9;
			}
		}
	}
	{
		return (bool)0;
	}

IL_001b:
	{
		__this->set_U3CU3E1__state_0((-1));
		// if (delayDuration > 0f)
		float L_2 = __this->get_delayDuration_2();
		if ((!(((float)L_2) > ((float)(0.0f)))))
		{
			goto IL_004b;
		}
	}
	{
		// yield return delay;
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_3 = __this->get_delay_3();
		__this->set_U3CU3E2__current_1(L_3);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0044:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_004b:
	{
		// float timeLeft = duration;
		float L_4 = __this->get_duration_4();
		__this->set_U3CtimeLeftU3E5__2_10(L_4);
		goto IL_00d0;
	}

IL_0059:
	{
		// targetTransform.transform.position = MMTween.Tween(duration - timeLeft, 0f, duration, origin, destination, curve);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_5 = __this->get_targetTransform_5();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_6;
		L_6 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_5, /*hidden argument*/NULL);
		float L_7 = __this->get_duration_4();
		float L_8 = __this->get_U3CtimeLeftU3E5__2_10();
		float L_9 = __this->get_duration_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = __this->get_origin_6();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_11 = __this->get_destination_7();
		int32_t L_12 = __this->get_curve_8();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_13;
		L_13 = MMTween_Tween_m2BDC8328BE236482F235949CE01A9CE2118CA21E(((float)il2cpp_codegen_subtract((float)L_7, (float)L_8)), (0.0f), L_9, L_10, L_11, L_12, /*hidden argument*/NULL);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_6, L_13, /*hidden argument*/NULL);
		// timeLeft -= ignoreTimescale ? Time.unscaledDeltaTime : Time.deltaTime;
		float L_14 = __this->get_U3CtimeLeftU3E5__2_10();
		bool L_15 = __this->get_ignoreTimescale_9();
		G_B7_0 = L_14;
		G_B7_1 = __this;
		if (L_15)
		{
			G_B8_0 = L_14;
			G_B8_1 = __this;
			goto IL_00ae;
		}
	}
	{
		float L_16;
		L_16 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		G_B9_0 = L_16;
		G_B9_1 = G_B7_0;
		G_B9_2 = G_B7_1;
		goto IL_00b3;
	}

IL_00ae:
	{
		float L_17;
		L_17 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		G_B9_0 = L_17;
		G_B9_1 = G_B8_0;
		G_B9_2 = G_B8_1;
	}

IL_00b3:
	{
		G_B9_2->set_U3CtimeLeftU3E5__2_10(((float)il2cpp_codegen_subtract((float)G_B9_1, (float)G_B9_0)));
		// yield return null;
		__this->set_U3CU3E2__current_1(NULL);
		__this->set_U3CU3E1__state_0(2);
		return (bool)1;
	}

IL_00c9:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_00d0:
	{
		// while (timeLeft > 0f)
		float L_18 = __this->get_U3CtimeLeftU3E5__2_10();
		if ((((float)L_18) > ((float)(0.0f))))
		{
			goto IL_0059;
		}
	}
	{
		// targetTransform.transform.position = destination;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_19 = __this->get_targetTransform_5();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_20;
		L_20 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_19, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_21 = __this->get_destination_7();
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_20, L_21, /*hidden argument*/NULL);
		// }
		return (bool)0;
	}
}
// System.Object MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CMoveTransformCoU3Ed__18_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mC83EE03C63D2EEA61E317B07FDABA0F0985B3371 (U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CMoveTransformCoU3Ed__18_System_Collections_IEnumerator_Reset_m1437A932F8A0493E283C42D4F82D0C5F781C869E (U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * __this, const RuntimeMethod* method)
{
	{
		NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * L_0 = (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CMoveTransformCoU3Ed__18_System_Collections_IEnumerator_Reset_m1437A932F8A0493E283C42D4F82D0C5F781C869E_RuntimeMethod_var)));
	}
}
// System.Object MoreMountains.Tools.MMTween/<MoveTransformCo>d__18::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CMoveTransformCoU3Ed__18_System_Collections_IEnumerator_get_Current_mF6B9949F49B6914FA53EC20C449E7C21801B2EB8 (U3CMoveTransformCoU3Ed__18_t9EC13165AB19FB490A001428C863F37920A54A41 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CMoveTransformCoU3Ed__19__ctor_mDE6F99CFBFB9B28B56F448863BAA2E70B12E0572 (U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CMoveTransformCoU3Ed__19_System_IDisposable_Dispose_m120B854F8BEC434FD87885CAE5F34305EB6D7A09 (U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CMoveTransformCoU3Ed__19_MoveNext_mACD142BFF3EEDA3B4DF254A56C682B6E9DBC92D8 (U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	float G_B12_0 = 0.0f;
	U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * G_B12_1 = NULL;
	float G_B11_0 = 0.0f;
	U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * G_B11_1 = NULL;
	float G_B13_0 = 0.0f;
	float G_B13_1 = 0.0f;
	U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * G_B13_2 = NULL;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		int32_t L_1 = V_0;
		switch (L_1)
		{
			case 0:
			{
				goto IL_001b;
			}
			case 1:
			{
				goto IL_0044;
			}
			case 2:
			{
				goto IL_012f;
			}
		}
	}
	{
		return (bool)0;
	}

IL_001b:
	{
		__this->set_U3CU3E1__state_0((-1));
		// if (delayDuration > 0f)
		float L_2 = __this->get_delayDuration_2();
		if ((!(((float)L_2) > ((float)(0.0f)))))
		{
			goto IL_004b;
		}
	}
	{
		// yield return delay;
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_3 = __this->get_delay_3();
		__this->set_U3CU3E2__current_1(L_3);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0044:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_004b:
	{
		// float timeLeft = duration;
		float L_4 = __this->get_duration_4();
		__this->set_U3CtimeLeftU3E5__2_12(L_4);
		goto IL_0136;
	}

IL_005c:
	{
		// if (updatePosition)
		bool L_5 = __this->get_updatePosition_5();
		if (!L_5)
		{
			goto IL_00ad;
		}
	}
	{
		// targetTransform.transform.position = MMTween.Tween(duration - timeLeft, 0f, duration, origin.position, destination.position, curve);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_6 = __this->get_targetTransform_6();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_7;
		L_7 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_6, /*hidden argument*/NULL);
		float L_8 = __this->get_duration_4();
		float L_9 = __this->get_U3CtimeLeftU3E5__2_12();
		float L_10 = __this->get_duration_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_11 = __this->get_origin_7();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_12;
		L_12 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_11, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_13 = __this->get_destination_8();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_14;
		L_14 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_13, /*hidden argument*/NULL);
		int32_t L_15 = __this->get_curve_9();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_16;
		L_16 = MMTween_Tween_m2BDC8328BE236482F235949CE01A9CE2118CA21E(((float)il2cpp_codegen_subtract((float)L_8, (float)L_9)), (0.0f), L_10, L_12, L_14, L_15, /*hidden argument*/NULL);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_7, L_16, /*hidden argument*/NULL);
	}

IL_00ad:
	{
		// if (updateRotation)
		bool L_17 = __this->get_updateRotation_10();
		if (!L_17)
		{
			goto IL_00fe;
		}
	}
	{
		// targetTransform.transform.rotation = MMTween.Tween(duration - timeLeft, 0f, duration, origin.rotation, destination.rotation, curve);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_18 = __this->get_targetTransform_6();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_19;
		L_19 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_18, /*hidden argument*/NULL);
		float L_20 = __this->get_duration_4();
		float L_21 = __this->get_U3CtimeLeftU3E5__2_12();
		float L_22 = __this->get_duration_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_23 = __this->get_origin_7();
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_24;
		L_24 = Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200(L_23, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_25 = __this->get_destination_8();
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_26;
		L_26 = Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200(L_25, /*hidden argument*/NULL);
		int32_t L_27 = __this->get_curve_9();
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_28;
		L_28 = MMTween_Tween_mF03B1E6E05B524C61DED95B33F1E3C968C4513F5(((float)il2cpp_codegen_subtract((float)L_20, (float)L_21)), (0.0f), L_22, L_24, L_26, L_27, /*hidden argument*/NULL);
		Transform_set_rotation_m1B5F3D4CE984AB31254615C9C71B0E54978583B4(L_19, L_28, /*hidden argument*/NULL);
	}

IL_00fe:
	{
		// timeLeft -= ignoreTimescale ? Time.unscaledDeltaTime : Time.deltaTime;
		float L_29 = __this->get_U3CtimeLeftU3E5__2_12();
		bool L_30 = __this->get_ignoreTimescale_11();
		G_B11_0 = L_29;
		G_B11_1 = __this;
		if (L_30)
		{
			G_B12_0 = L_29;
			G_B12_1 = __this;
			goto IL_0114;
		}
	}
	{
		float L_31;
		L_31 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		G_B13_0 = L_31;
		G_B13_1 = G_B11_0;
		G_B13_2 = G_B11_1;
		goto IL_0119;
	}

IL_0114:
	{
		float L_32;
		L_32 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		G_B13_0 = L_32;
		G_B13_1 = G_B12_0;
		G_B13_2 = G_B12_1;
	}

IL_0119:
	{
		G_B13_2->set_U3CtimeLeftU3E5__2_12(((float)il2cpp_codegen_subtract((float)G_B13_1, (float)G_B13_0)));
		// yield return null;
		__this->set_U3CU3E2__current_1(NULL);
		__this->set_U3CU3E1__state_0(2);
		return (bool)1;
	}

IL_012f:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_0136:
	{
		// while (timeLeft > 0f)
		float L_33 = __this->get_U3CtimeLeftU3E5__2_12();
		if ((((float)L_33) > ((float)(0.0f))))
		{
			goto IL_005c;
		}
	}
	{
		// if (updatePosition) { targetTransform.transform.position = destination.position; }
		bool L_34 = __this->get_updatePosition_5();
		if (!L_34)
		{
			goto IL_0169;
		}
	}
	{
		// if (updatePosition) { targetTransform.transform.position = destination.position; }
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_35 = __this->get_targetTransform_6();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_36;
		L_36 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_35, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_37 = __this->get_destination_8();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_38;
		L_38 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_37, /*hidden argument*/NULL);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_36, L_38, /*hidden argument*/NULL);
	}

IL_0169:
	{
		// if (updateRotation) { targetTransform.transform.localEulerAngles = destination.localEulerAngles; }
		bool L_39 = __this->get_updateRotation_10();
		if (!L_39)
		{
			goto IL_018c;
		}
	}
	{
		// if (updateRotation) { targetTransform.transform.localEulerAngles = destination.localEulerAngles; }
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_40 = __this->get_targetTransform_6();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_41;
		L_41 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_40, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_42 = __this->get_destination_8();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_43;
		L_43 = Transform_get_localEulerAngles_m4C442107F523737ADAB54855FDC1777A9B71D545(L_42, /*hidden argument*/NULL);
		Transform_set_localEulerAngles_mB63076996124DC76E6902A81677A6E3C814C693B(L_41, L_43, /*hidden argument*/NULL);
	}

IL_018c:
	{
		// }
		return (bool)0;
	}
}
// System.Object MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CMoveTransformCoU3Ed__19_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mFF0C95E337F9D236ECE7454FDF5A424300E75B12 (U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CMoveTransformCoU3Ed__19_System_Collections_IEnumerator_Reset_mEB44C68F9A8677925955B3DADCC976CD6B96B77F (U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * __this, const RuntimeMethod* method)
{
	{
		NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * L_0 = (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CMoveTransformCoU3Ed__19_System_Collections_IEnumerator_Reset_mEB44C68F9A8677925955B3DADCC976CD6B96B77F_RuntimeMethod_var)));
	}
}
// System.Object MoreMountains.Tools.MMTween/<MoveTransformCo>d__19::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CMoveTransformCoU3Ed__19_System_Collections_IEnumerator_get_Current_m2911C4DB3F5C5A234AD085968F27107869019B6C (U3CMoveTransformCoU3Ed__19_t42B421997D9070ADAA988B32B64A9674A95F287F * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRotateTransformAroundCoU3Ed__20__ctor_mDE99FCBA73D4079DE5173490BB0374636D3DD9AE (U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRotateTransformAroundCoU3Ed__20_System_IDisposable_Dispose_m60ABB163C2609C0CC1B706EE85FB0C11D615603A (U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CRotateTransformAroundCoU3Ed__20_MoveNext_mD524F2DC238799B234267C96866600D01C9E16FC (U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_1;
	memset((&V_1), 0, sizeof(V_1));
	float V_2 = 0.0f;
	float G_B8_0 = 0.0f;
	U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * G_B8_1 = NULL;
	float G_B7_0 = 0.0f;
	U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * G_B7_1 = NULL;
	float G_B9_0 = 0.0f;
	float G_B9_1 = 0.0f;
	U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * G_B9_2 = NULL;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		int32_t L_1 = V_0;
		switch (L_1)
		{
			case 0:
			{
				goto IL_001b;
			}
			case 1:
			{
				goto IL_0044;
			}
			case 2:
			{
				goto IL_014c;
			}
		}
	}
	{
		return (bool)0;
	}

IL_001b:
	{
		__this->set_U3CU3E1__state_0((-1));
		// if (delayDuration > 0f)
		float L_2 = __this->get_delayDuration_2();
		if ((!(((float)L_2) > ((float)(0.0f)))))
		{
			goto IL_004b;
		}
	}
	{
		// yield return delay;
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_3 = __this->get_delay_3();
		__this->set_U3CU3E2__current_1(L_3);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0044:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_004b:
	{
		// Vector3 initialRotationPosition = targetTransform.transform.position;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_4 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_5;
		L_5 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_4, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6;
		L_6 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_5, /*hidden argument*/NULL);
		__this->set_U3CinitialRotationPositionU3E5__2_11(L_6);
		// Quaternion initialRotationRotation = targetTransform.transform.rotation;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_7 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_8;
		L_8 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_7, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_9;
		L_9 = Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200(L_8, /*hidden argument*/NULL);
		V_1 = L_9;
		// float rate = 1f / duration;
		float L_10 = __this->get_duration_5();
		// float timeSpent = 0f;
		__this->set_U3CtimeSpentU3E5__3_12((0.0f));
		goto IL_0153;
	}

IL_008f:
	{
		// float newAngle = MMTween.Tween(timeSpent, 0f, duration, 0f, angle, curve);
		float L_11 = __this->get_U3CtimeSpentU3E5__3_12();
		float L_12 = __this->get_duration_5();
		float L_13 = __this->get_angle_6();
		int32_t L_14 = __this->get_curve_7();
		float L_15;
		L_15 = MMTween_Tween_m5DDB8ECB3E521801BF6A78B65C55B14E5FA7A959(L_11, (0.0f), L_12, (0.0f), L_13, L_14, /*hidden argument*/NULL);
		V_2 = L_15;
		// targetTransform.transform.position = initialRotationPosition;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_16 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_17;
		L_17 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_16, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_18 = __this->get_U3CinitialRotationPositionU3E5__2_11();
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_17, L_18, /*hidden argument*/NULL);
		// initialRotationRotation = targetTransform.transform.rotation;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_19 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_20;
		L_20 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_19, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_21;
		L_21 = Transform_get_rotation_m4AA3858C00DF4C9614B80352558C4C37D08D2200(L_20, /*hidden argument*/NULL);
		V_1 = L_21;
		// targetTransform.RotateAround(center.transform.position, center.transform.up, newAngle);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_22 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_23 = __this->get_center_8();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_24;
		L_24 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_23, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_25;
		L_25 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_24, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_26 = __this->get_center_8();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_27;
		L_27 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_26, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_28;
		L_28 = Transform_get_up_mAB753D250A30C78924D5D22B0821F1D254525C31(L_27, /*hidden argument*/NULL);
		float L_29 = V_2;
		Transform_RotateAround_m1F93A7A1807BE407BD23EC1BA49F03AD22FCE4BE(L_22, L_25, L_28, L_29, /*hidden argument*/NULL);
		// targetTransform.transform.rotation = initialRotationRotation;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_30 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_31;
		L_31 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_30, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_32 = V_1;
		Transform_set_rotation_m1B5F3D4CE984AB31254615C9C71B0E54978583B4(L_31, L_32, /*hidden argument*/NULL);
		// timeSpent += ignoreTimescale ? Time.unscaledDeltaTime : Time.deltaTime;
		float L_33 = __this->get_U3CtimeSpentU3E5__3_12();
		bool L_34 = __this->get_ignoreTimescale_9();
		G_B7_0 = L_33;
		G_B7_1 = __this;
		if (L_34)
		{
			G_B8_0 = L_33;
			G_B8_1 = __this;
			goto IL_0131;
		}
	}
	{
		float L_35;
		L_35 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		G_B9_0 = L_35;
		G_B9_1 = G_B7_0;
		G_B9_2 = G_B7_1;
		goto IL_0136;
	}

IL_0131:
	{
		float L_36;
		L_36 = Time_get_unscaledDeltaTime_m2C153F1E5C77C6AF655054BC6C76D0C334C0DC84(/*hidden argument*/NULL);
		G_B9_0 = L_36;
		G_B9_1 = G_B8_0;
		G_B9_2 = G_B8_1;
	}

IL_0136:
	{
		G_B9_2->set_U3CtimeSpentU3E5__3_12(((float)il2cpp_codegen_add((float)G_B9_1, (float)G_B9_0)));
		// yield return null;
		__this->set_U3CU3E2__current_1(NULL);
		__this->set_U3CU3E1__state_0(2);
		return (bool)1;
	}

IL_014c:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_0153:
	{
		// while (timeSpent < duration)
		float L_37 = __this->get_U3CtimeSpentU3E5__3_12();
		float L_38 = __this->get_duration_5();
		if ((((float)L_37) < ((float)L_38)))
		{
			goto IL_008f;
		}
	}
	{
		// targetTransform.transform.position = destination.position;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_39 = __this->get_targetTransform_4();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_40;
		L_40 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_39, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_41 = __this->get_destination_10();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_42;
		L_42 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_41, /*hidden argument*/NULL);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_40, L_42, /*hidden argument*/NULL);
		// }
		return (bool)0;
	}
}
// System.Object MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CRotateTransformAroundCoU3Ed__20_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_m3B7E300D8726DF05EB1B161FD704A2AC376AE1D2 (U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CRotateTransformAroundCoU3Ed__20_System_Collections_IEnumerator_Reset_mB4AB4E0ADA3CA0EE323503337E886B41DA95627E (U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * __this, const RuntimeMethod* method)
{
	{
		NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * L_0 = (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CRotateTransformAroundCoU3Ed__20_System_Collections_IEnumerator_Reset_mB4AB4E0ADA3CA0EE323503337E886B41DA95627E_RuntimeMethod_var)));
	}
}
// System.Object MoreMountains.Tools.MMTween/<RotateTransformAroundCo>d__20::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CRotateTransformAroundCoU3Ed__20_System_Collections_IEnumerator_get_Current_m3A34C91ED0FEBB3C92A26D67CB714F9D34BAF876 (U3CRotateTransformAroundCoU3Ed__20_tCCD68B13D3BB46A7F980D82CA7AD350C62E23A14 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59 (Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59 * __this, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  ___item0, const RuntimeMethod* method)
{


	typedef void (DEFAULT_CALL *PInvokeFunc)(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Marshaling of parameter '___item0' to native representation
	DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshaled_pinvoke ____item0_marshaled = {};
	DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshal_pinvoke(___item0, ____item0_marshaled);

	// Native function invocation
	il2cppPInvokeFunc(____item0_marshaled);

	// Marshaling cleanup of parameter '___item0' native representation
	DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_marshal_pinvoke_cleanup(____item0_marshaled);

}
// System.Void MoreMountains.Tools.MMDebug/MMDebugLogEvent/Delegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Delegate__ctor_mBDCF94F9BB75CDA98AB283EA573C1725B5334598 (Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void MoreMountains.Tools.MMDebug/MMDebugLogEvent/Delegate::Invoke(MoreMountains.Tools.MMDebug/DebugLogItem)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Delegate_Invoke_m5DDA42BC51F74F72C6BAF74F4F9E8C9F94FF6DDE (Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59 * __this, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  ___item0, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___item0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___item0, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  >::Invoke(targetMethod, targetThis, ___item0);
					else
						GenericVirtActionInvoker1< DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  >::Invoke(targetMethod, targetThis, ___item0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___item0);
					else
						VirtActionInvoker1< DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___item0);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((RuntimeObject*)(reinterpret_cast<RuntimeObject*>(&___item0) - 1), targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06 , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___item0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult MoreMountains.Tools.MMDebug/MMDebugLogEvent/Delegate::BeginInvoke(MoreMountains.Tools.MMDebug/DebugLogItem,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Delegate_BeginInvoke_m36A9A8F9DBF50CC3847DAA27F16648F80493D56D (Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59 * __this, DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06  ___item0, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(DebugLogItem_t76ECBB114973092E77B44C97FA91CD667ABF5D06_il2cpp_TypeInfo_var, &___item0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void MoreMountains.Tools.MMDebug/MMDebugLogEvent/Delegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Delegate_EndInvoke_m5E9A2975B2A208D66F8C94E2F721377B16A66732 (Delegate_tCFA34CF52D5DC49DFB5950A663D28F0C2E157B59 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705 (ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705 * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonDownMethodDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonDownMethodDelegate__ctor_m251A721718BCB8FAF57DC2F58BCA5B021C103D18 (ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonDownMethodDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonDownMethodDelegate_Invoke_mD9F4364D37595B97FFA55C20569D47819303A44D (ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705 * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult MoreMountains.Tools.MMInput/IMButton/ButtonDownMethodDelegate::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ButtonDownMethodDelegate_BeginInvoke_mE364DF4BBBE13B1B3EF59B6F820C7E8AD887C2E8 (ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705 * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonDownMethodDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonDownMethodDelegate_EndInvoke_m764B88808C6789226428A0C93E0EF98E074ABDCA (ButtonDownMethodDelegate_tEAD0F8082ADF18F5A4B75DC9537AB476936C0705 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B (ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonPressedMethodDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonPressedMethodDelegate__ctor_mB3C5A91ABC2D224B068D08D05BDA6893AFDA72BD (ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonPressedMethodDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonPressedMethodDelegate_Invoke_mBFB38F8EB9F14439CBFB6111D819DF3600255FDC (ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult MoreMountains.Tools.MMInput/IMButton/ButtonPressedMethodDelegate::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ButtonPressedMethodDelegate_BeginInvoke_m80115DC8860BC90B76B79D73C90AE9F929796068 (ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonPressedMethodDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonPressedMethodDelegate_EndInvoke_m800AA870E09D590E9B261CD56ABFD016D6FB0603 (ButtonPressedMethodDelegate_t43D6759B02ECF8D0D95FFE6D6A7631177CB3004B * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C (ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonUpMethodDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonUpMethodDelegate__ctor_mA93D386B9222C53EF32795D7CEDE5A5219194F15 (ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonUpMethodDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonUpMethodDelegate_Invoke_mA1FD552BADE8B723293FDC4B0BD99618999FEC3E (ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult MoreMountains.Tools.MMInput/IMButton/ButtonUpMethodDelegate::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ButtonUpMethodDelegate_BeginInvoke_m065F4392B196EFFEA13E7F522894980A9E0DC1B6 (ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void MoreMountains.Tools.MMInput/IMButton/ButtonUpMethodDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ButtonUpMethodDelegate_EndInvoke_m39AC1C0E7DF70021AD6EA4B73C670E590114142E (ButtonUpMethodDelegate_tA2C0D2EA1AA9D4C113039CF27742E0BA1C72862C * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
