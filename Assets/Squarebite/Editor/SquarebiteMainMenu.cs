// (c) Copyright Bjakuja, 2013. All rights reserved.

using UnityEditor;
using UnityEngine;
using System.Collections;


static class SquarebiteMainMenu
{
    
    private const string MenuRoot = "Tools/"; 
	
	#region Create System
	
	[MenuItem(MenuRoot + "Squarebite/Create system/UI Root")]
	public static void CreateUIRoot()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/UI Root.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "UI Root";

	}

	[MenuItem(MenuRoot + "Squarebite/Create system/Level manager")]
	public static void CreateLevelManager()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/LevelManager.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "LevelManager";
	}
	
	[MenuItem(MenuRoot + "Squarebite/Create system/Object interact system")]
	public static void CreateObjectInteractSystem()
	{
		
		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/ObjectInteractSystem.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "ObjectInteractSystem";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create system/Inventory")]
	public static void CreateInventory()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/Inventory.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "Inventory";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create system/Shop")]
	public static void CreateShop()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/ShopSystem.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "ShopSystem";

	}


	[MenuItem(MenuRoot + "Squarebite/Create system/Container")]
	public static void CreateContainer()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/ContainerSystem.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "Container";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create system/Loot")]
	public static void CreateLoot()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/LootSystem.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "ContainerForDeadBody";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create system/Workbench")]
	public static void CreateWorkbench()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/Workbench.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "Workbench";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/Player")]
	public static void CreatePlayer()
	{
		
		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/Player.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "Player";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/Progress Bar")]
	public static void CreateProgressBar()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/ProgressBar.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "ProgressBar";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/Crafting Database")]
	public static void CreateCraftingDatabase()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/CraftingDatabase.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "CraftingDatabase";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/PlayerStatsGUI")]
	public static void CreatePlayerStatsGUI()
	{
		
		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/PlayerStatsGUI.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "PlayerStatsGUI";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/Equipment")]
	public static void CreateEquipment()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/Equipment.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "Equipment";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/PlayerStats")]
	public static void CreatePlayerStats()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/PlayerStats.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "PlayerStats";

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/MainCamera")]
	public static void CreateMainCamera()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/MainCamera.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "MainCamera";

	}	
	
	[MenuItem(MenuRoot + "Squarebite/Create sub system/GUICamera")]
	public static void CreateGUICamera()
	{

		GameObject go;
		Object obj = AssetDatabase.LoadAssetAtPath("Assets/Squarebite/SystemResource/GUICamera.prefab", typeof(GameObject));
		go = GameObject.Instantiate(obj) as GameObject;
		go.name = "GUICamera";

	}
	
	#endregion
	
	#region Create Item
	
	[MenuItem(MenuRoot + "Squarebite/Create Item/Apparel")]
	public static void CreateApparel()
	{
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/3D/Apparel.prefab", "Assets/Squarebite/NewCreatedItems/3D/Apparel.prefab");
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/GUI/Apparel.prefab", "Assets/Squarebite/NewCreatedItems/GUI/Apparel.prefab");
		AssetDatabase.Refresh();

	}

	[MenuItem(MenuRoot + "Squarebite/Create Item/Weapon")]
	public static void CreateWeapon()
	{
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/3D/Weapon.prefab", "Assets/Squarebite/NewCreatedItems/3D/Weapon.prefab");
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/GUI/Weapon.prefab", "Assets/Squarebite/NewCreatedItems/GUI/Weapon.prefab");
		AssetDatabase.Refresh();

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create Item/Consumable")]
	public static void CreateConsumable()
	{
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/3D/Consumable.prefab", "Assets/Squarebite/NewCreatedItems/3D/Consumable.prefab");
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/GUI/Consumable.prefab", "Assets/Squarebite/NewCreatedItems/GUI/Consumable.prefab");
		AssetDatabase.Refresh();

	}
	
	[MenuItem(MenuRoot + "Squarebite/Create Item/Other")]
	public static void CreateOther()
	{
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/3D/Other.prefab", "Assets/Squarebite/NewCreatedItems/3D/Other.prefab");
		AssetDatabase.CopyAsset("Assets/Squarebite/SystemResource/ItemSource/GUI/Other.prefab", "Assets/Squarebite/NewCreatedItems/GUI/Other.prefab");
		AssetDatabase.Refresh();

	}
		
	#endregion


	#region Documentation


//    [MenuItem(MenuRoot + "Squarebite/Online Resources/Web player")]
//	public static void WebPlayerDemo()
//	{
//		Application.OpenURL("http://www.crackedpiston.com/squarebite-inventory-demo.html");
//	}

    [MenuItem(MenuRoot + "Squarebite/Online Resources/YouTube Channel")]
	public static void YouTubeChannel()
	{
		Application.OpenURL("http://http://www.youtube.com/channel/UC_X1BK5Hz49Qcw48PB4ibag/videos");
	}

    [MenuItem(MenuRoot + "Squarebite/Online Resources/Squarebite Forum")]
	public static void SquarebiteForum()
	{
		Application.OpenURL("http://squarebite.proboards.com/");
	}
	
	[MenuItem(MenuRoot + "Squarebite/Changelog")]
	public static void SquarebiteChangelog()
	{
		Application.OpenURL("http://squarebite.proboards.com/thread/3/squarebite-change-log");
	}

	[MenuItem(MenuRoot + "Squarebite/Squarebite guide")]
	public static void SquarebiteGuide()
	{
		EditorUtility.OpenWithDefaultApp("Assets/Squarebite/Docs and Guide/Squarebite GUIDE.pdf");
	}
	
	[MenuItem(MenuRoot + "Squarebite/About Squarebite...")]
	public static void SquaretronicABOUT()
	{
		EditorUtility.OpenWithDefaultApp("Assets/Squarebite/Docs and Guide/About Squarebite.pdf");
    }
	
	#endregion
	
}
