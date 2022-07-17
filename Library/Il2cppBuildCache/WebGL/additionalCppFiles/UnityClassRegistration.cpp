extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_AI();
	RegisterModule_AI();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Director();
	RegisterModule_Director();

	void RegisterModule_Grid();
	RegisterModule_Grid();

	void RegisterModule_ImageConversion();
	RegisterModule_ImageConversion();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_Input();
	RegisterModule_Input();

	void RegisterModule_InputLegacy();
	RegisterModule_InputLegacy();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_RuntimeInitializeOnLoadManagerInitializer();
	RegisterModule_RuntimeInitializeOnLoadManagerInitializer();

	void RegisterModule_ScreenCapture();
	RegisterModule_ScreenCapture();

	void RegisterModule_Subsystems();
	RegisterModule_Subsystems();

	void RegisterModule_Terrain();
	RegisterModule_Terrain();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_TextCore();
	RegisterModule_TextCore();

	void RegisterModule_Tilemap();
	RegisterModule_Tilemap();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_Video();
	RegisterModule_Video();

	void RegisterModule_VR();
	RegisterModule_VR();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

	void RegisterModule_XR();
	RegisterModule_XR();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

namespace ObjectProduceTestTypes { class Derived; } 
namespace ObjectProduceTestTypes { class SubDerived; } 
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class Animation; template <> void RegisterUnityClass<Animation>(const char*);
class Animator; template <> void RegisterUnityClass<Animator>(const char*);
namespace Unity { class ArticulationBody; } 
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class AudioFilter; template <> void RegisterUnityClass<AudioFilter>(const char*);
class AudioChorusFilter; 
class AudioDistortionFilter; template <> void RegisterUnityClass<AudioDistortionFilter>(const char*);
class AudioEchoFilter; template <> void RegisterUnityClass<AudioEchoFilter>(const char*);
class AudioHighPassFilter; template <> void RegisterUnityClass<AudioHighPassFilter>(const char*);
class AudioLowPassFilter; template <> void RegisterUnityClass<AudioLowPassFilter>(const char*);
class AudioReverbFilter; template <> void RegisterUnityClass<AudioReverbFilter>(const char*);
class AudioReverbZone; 
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterUnityClass<Collider2D>(const char*);
class BoxCollider2D; template <> void RegisterUnityClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; 
class CircleCollider2D; template <> void RegisterUnityClass<CircleCollider2D>(const char*);
class CompositeCollider2D; template <> void RegisterUnityClass<CompositeCollider2D>(const char*);
class EdgeCollider2D; 
class PolygonCollider2D; template <> void RegisterUnityClass<PolygonCollider2D>(const char*);
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; 
class GridLayout; template <> void RegisterUnityClass<GridLayout>(const char*);
class Grid; template <> void RegisterUnityClass<Grid>(const char*);
class Tilemap; template <> void RegisterUnityClass<Tilemap>(const char*);
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class LookAtConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; template <> void RegisterUnityClass<Light>(const char*);
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class NavMeshAgent; template <> void RegisterUnityClass<NavMeshAgent>(const char*);
class NavMeshObstacle; 
class OffMeshLink; 
class ParticleSystemForceField; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; template <> void RegisterUnityClass<PlayableDirector>(const char*);
class Projector; 
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Skybox; 
class SortingGroup; 
class StreamingController; 
class Terrain; template <> void RegisterUnityClass<Terrain>(const char*);
class VideoPlayer; template <> void RegisterUnityClass<VideoPlayer>(const char*);
class VisualEffect; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);
class Collider; template <> void RegisterUnityClass<Collider>(const char*);
class BoxCollider; template <> void RegisterUnityClass<BoxCollider>(const char*);
class CapsuleCollider; template <> void RegisterUnityClass<CapsuleCollider>(const char*);
class CharacterController; template <> void RegisterUnityClass<CharacterController>(const char*);
class MeshCollider; template <> void RegisterUnityClass<MeshCollider>(const char*);
class SphereCollider; template <> void RegisterUnityClass<SphereCollider>(const char*);
class TerrainCollider; 
class WheelCollider; 
class FakeComponent; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleSystem; template <> void RegisterUnityClass<ParticleSystem>(const char*);
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; template <> void RegisterUnityClass<LineRenderer>(const char*);
class RendererFake; 
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class ParticleSystemRenderer; template <> void RegisterUnityClass<ParticleSystemRenderer>(const char*);
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class SpriteShapeRenderer; 
class TilemapRenderer; template <> void RegisterUnityClass<TilemapRenderer>(const char*);
class TrailRenderer; template <> void RegisterUnityClass<TrailRenderer>(const char*);
class VFXRenderer; 
class Rigidbody; template <> void RegisterUnityClass<Rigidbody>(const char*);
class Rigidbody2D; template <> void RegisterUnityClass<Rigidbody2D>(const char*);
namespace TextRenderingPrivate { class TextMesh; } template <> void RegisterUnityClass<TextRenderingPrivate::TextMesh>(const char*);
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class Tree; 
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class AudioMixer; template <> void RegisterUnityClass<AudioMixer>(const char*);
class AudioMixerController; 
class AudioMixerGroup; template <> void RegisterUnityClass<AudioMixerGroup>(const char*);
class AudioMixerGroupController; 
class AudioMixerSnapshot; template <> void RegisterUnityClass<AudioMixerSnapshot>(const char*);
class AudioMixerSnapshotController; 
class Avatar; template <> void RegisterUnityClass<Avatar>(const char*);
class AvatarMask; template <> void RegisterUnityClass<AvatarMask>(const char*);
class BillboardAsset; 
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
class LightProbes; template <> void RegisterUnityClass<LightProbes>(const char*);
class LightingSettings; template <> void RegisterUnityClass<LightingSettings>(const char*);
class LocalizationAsset; 
class Material; template <> void RegisterUnityClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class Motion; template <> void RegisterUnityClass<Motion>(const char*);
class AnimationClip; template <> void RegisterUnityClass<AnimationClip>(const char*);
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class RayTracingShader; 
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AnimatorController; template <> void RegisterUnityClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SubstanceArchive; 
class TerrainData; template <> void RegisterUnityClass<TerrainData>(const char*);
class TerrainLayer; 
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class BaseVideoTexture; 
class WebCamTexture; 
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class VideoClip; 
class VisualEffectObject; 
class VisualEffectAsset; 
class VisualEffectSubgraph; 
class EmptyObject; 
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class NavMeshProjectSettings; template <> void RegisterUnityClass<NavMeshProjectSettings>(const char*);
class Physics2DSettings; template <> void RegisterUnityClass<Physics2DSettings>(const char*);
class PhysicsManager; template <> void RegisterUnityClass<PhysicsManager>(const char*);
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterUnityClass<ScriptMapper>(const char*);
class StreamingManager; 
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class UnityConnectSettings; 
class VFXManager; 
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class NavMeshSettings; template <> void RegisterUnityClass<NavMeshSettings>(const char*);
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class NativeObjectType; 
class PropertyModificationsTargetTestObject; 
class SerializableManagedHost; 
class SerializableManagedRefTestClass; 
namespace ObjectProduceTestTypes { class SiblingDerived; } 
class TestObjectVectorPairStringBool; 
class TestObjectWithSerializedAnimationCurve; 
class TestObjectWithSerializedArray; 
class TestObjectWithSerializedMapStringBool; 
class TestObjectWithSerializedMapStringNonAlignedStruct; 
class TestObjectWithSpecialLayoutOne; 
class TestObjectWithSpecialLayoutTwo; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 111 non stripped classes
	//0. NavMeshAgent
	RegisterUnityClass<NavMeshAgent>("AI");
	//1. NavMeshProjectSettings
	RegisterUnityClass<NavMeshProjectSettings>("AI");
	//2. NavMeshSettings
	RegisterUnityClass<NavMeshSettings>("AI");
	//3. Animation
	RegisterUnityClass<Animation>("Animation");
	//4. AnimationClip
	RegisterUnityClass<AnimationClip>("Animation");
	//5. Animator
	RegisterUnityClass<Animator>("Animation");
	//6. AnimatorController
	RegisterUnityClass<AnimatorController>("Animation");
	//7. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//8. Avatar
	RegisterUnityClass<Avatar>("Animation");
	//9. AvatarMask
	RegisterUnityClass<AvatarMask>("Animation");
	//10. Motion
	RegisterUnityClass<Motion>("Animation");
	//11. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//12. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//13. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//14. AudioDistortionFilter
	RegisterUnityClass<AudioDistortionFilter>("Audio");
	//15. AudioEchoFilter
	RegisterUnityClass<AudioEchoFilter>("Audio");
	//16. AudioFilter
	RegisterUnityClass<AudioFilter>("Audio");
	//17. AudioHighPassFilter
	RegisterUnityClass<AudioHighPassFilter>("Audio");
	//18. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//19. AudioLowPassFilter
	RegisterUnityClass<AudioLowPassFilter>("Audio");
	//20. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//21. AudioMixer
	RegisterUnityClass<AudioMixer>("Audio");
	//22. AudioMixerGroup
	RegisterUnityClass<AudioMixerGroup>("Audio");
	//23. AudioMixerSnapshot
	RegisterUnityClass<AudioMixerSnapshot>("Audio");
	//24. AudioReverbFilter
	RegisterUnityClass<AudioReverbFilter>("Audio");
	//25. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//26. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//27. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//28. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//29. Camera
	RegisterUnityClass<Camera>("Core");
	//30. Unity::Component
	RegisterUnityClass<Unity::Component>("Core");
	//31. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//32. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//33. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//34. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//35. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//36. GameManager
	RegisterUnityClass<GameManager>("Core");
	//37. GameObject
	RegisterUnityClass<GameObject>("Core");
	//38. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//39. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//40. InputManager
	RegisterUnityClass<InputManager>("Core");
	//41. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//42. Light
	RegisterUnityClass<Light>("Core");
	//43. LightingSettings
	RegisterUnityClass<LightingSettings>("Core");
	//44. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//45. LightProbes
	RegisterUnityClass<LightProbes>("Core");
	//46. LineRenderer
	RegisterUnityClass<LineRenderer>("Core");
	//47. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//48. Material
	RegisterUnityClass<Material>("Core");
	//49. Mesh
	RegisterUnityClass<Mesh>("Core");
	//50. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//51. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//52. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//53. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//54. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//55. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//56. Object
	//Skipping Object
	//57. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//58. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//59. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//60. UI::RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//61. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//62. Renderer
	RegisterUnityClass<Renderer>("Core");
	//63. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//64. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//65. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//66. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//67. ScriptMapper
	RegisterUnityClass<ScriptMapper>("Core");
	//68. Shader
	RegisterUnityClass<Shader>("Core");
	//69. Sprite
	RegisterUnityClass<Sprite>("Core");
	//70. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//71. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//72. TagManager
	RegisterUnityClass<TagManager>("Core");
	//73. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//74. Texture
	RegisterUnityClass<Texture>("Core");
	//75. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//76. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//77. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//78. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//79. TrailRenderer
	RegisterUnityClass<TrailRenderer>("Core");
	//80. Transform
	RegisterUnityClass<Transform>("Core");
	//81. PlayableDirector
	RegisterUnityClass<PlayableDirector>("Director");
	//82. Grid
	RegisterUnityClass<Grid>("Grid");
	//83. GridLayout
	RegisterUnityClass<GridLayout>("Grid");
	//84. ParticleSystem
	RegisterUnityClass<ParticleSystem>("ParticleSystem");
	//85. ParticleSystemRenderer
	RegisterUnityClass<ParticleSystemRenderer>("ParticleSystem");
	//86. BoxCollider
	RegisterUnityClass<BoxCollider>("Physics");
	//87. CapsuleCollider
	RegisterUnityClass<CapsuleCollider>("Physics");
	//88. CharacterController
	RegisterUnityClass<CharacterController>("Physics");
	//89. Collider
	RegisterUnityClass<Collider>("Physics");
	//90. MeshCollider
	RegisterUnityClass<MeshCollider>("Physics");
	//91. PhysicsManager
	RegisterUnityClass<PhysicsManager>("Physics");
	//92. Rigidbody
	RegisterUnityClass<Rigidbody>("Physics");
	//93. SphereCollider
	RegisterUnityClass<SphereCollider>("Physics");
	//94. BoxCollider2D
	RegisterUnityClass<BoxCollider2D>("Physics2D");
	//95. CircleCollider2D
	RegisterUnityClass<CircleCollider2D>("Physics2D");
	//96. Collider2D
	RegisterUnityClass<Collider2D>("Physics2D");
	//97. CompositeCollider2D
	RegisterUnityClass<CompositeCollider2D>("Physics2D");
	//98. Physics2DSettings
	RegisterUnityClass<Physics2DSettings>("Physics2D");
	//99. PolygonCollider2D
	RegisterUnityClass<PolygonCollider2D>("Physics2D");
	//100. Rigidbody2D
	RegisterUnityClass<Rigidbody2D>("Physics2D");
	//101. Terrain
	RegisterUnityClass<Terrain>("Terrain");
	//102. TerrainData
	RegisterUnityClass<TerrainData>("Terrain");
	//103. TextRendering::Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//104. TextRenderingPrivate::TextMesh
	RegisterUnityClass<TextRenderingPrivate::TextMesh>("TextRendering");
	//105. Tilemap
	RegisterUnityClass<Tilemap>("Tilemap");
	//106. TilemapRenderer
	RegisterUnityClass<TilemapRenderer>("Tilemap");
	//107. UI::Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//108. UI::CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//109. UI::CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");
	//110. VideoPlayer
	RegisterUnityClass<VideoPlayer>("Video");

}
