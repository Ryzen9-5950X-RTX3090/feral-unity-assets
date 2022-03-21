using UnityEngine;

namespace Gaia
{
	public class GaiaSettings : ScriptableObject
	{
		[Header("Current Settings")]
		public GaiaConstants.EnvironmentControllerType m_currentController;

		[Tooltip("Target size.")]
		public GaiaConstants.EnvironmentSize m_currentSize;

		[Tooltip("Current target environment.")]
		public GaiaConstants.EnvironmentTarget m_currentEnvironment;

		[Tooltip("Current target renderer.")]
		public GaiaConstants.EnvironmentRenderer m_currentRenderer;

		[Tooltip("Current defaults object.")]
		public GaiaDefaults m_currentDefaults;

		[Tooltip("Current terrain resources object.")]
		public GaiaResource m_currentResources;

		[Tooltip("Current game object resources object.")]
		public GaiaResource m_currentGameObjectResources;

		[Tooltip("Current size divisor.")]
		public float m_currentSizeDivisor;

		[Tooltip("Current prefab name for the player object.")]
		public string m_currentPlayerPrefabName;

		[Tooltip("Current prefab name for the water object.")]
		public string m_currentWaterPrefabName;

		[Tooltip("Current path for terrain layer storage. Must include 'Assets' at the beginning.")]
		public string m_currentTerrainLayerStoragePath;

		[Tooltip("Publisher name for exported extensions.")]
		public string m_publisherName;

		[Tooltip("Default prefab name for the first person player object.")]
		public string m_fpsPlayerPrefabName;

		[Tooltip("Default prefab name for the third person player object.")]
		public string m_3pPlayerPrefabName;

		[Tooltip("Default prefab name for the roller ball player object.")]
		public string m_rbPlayerPrefabName;

		[Tooltip("Default prefab name for the light weight water object.")]
		public string m_waterMobilePrefabName;

		[Tooltip("Default prefab name for the water object.")]
		public string m_waterPrefabName;

		[Tooltip("Show or hide tooltips in all custom editors.")]
		public bool m_showTooltips;

		[Header("Alternative Configurations")]
		[Tooltip("Ultra light defaults object.")]
		public GaiaDefaults m_ultraLightDefaults;

		[Tooltip("Ultra light resources object.")]
		public GaiaResource m_ultraLightResources;

		[Tooltip("Ultra light gameobject resources object.")]
		public GaiaResource m_ultraLightGameObjectResources;

		[Tooltip("Mobile defaults object.")]
		public GaiaDefaults m_mobileDefaults;

		[Tooltip("Mobile resources object.")]
		public GaiaResource m_mobileResources;

		[Tooltip("Mobile game object resources object.")]
		public GaiaResource m_mobileGameObjectResources;

		[Tooltip("Desktop defaults object.")]
		public GaiaDefaults m_desktopDefaults;

		[Tooltip("Desktop resources object.")]
		public GaiaResource m_desktopResources;

		[Tooltip("Desktop game object resources object.")]
		public GaiaResource m_desktopGameObjectResources;

		[Tooltip("Powerful desktop defaults object.")]
		public GaiaDefaults m_powerDesktopDefaults;

		[Tooltip("Powerful desktop resources object.")]
		public GaiaResource m_powerDesktopResources;

		[Tooltip("Powerful desktop gamem objcet resources object.")]
		public GaiaResource m_powerDesktopGameObjectResources;

		[Header("News")]
		public long m_lastWebUpdate;

		public bool m_hideHeroMessage;

		public string m_latestNewsTitle;

		public string m_latestNewsBody;

		public string m_latestNewsUrl;

		public Texture2D m_latestNewsImage;
	}
}
