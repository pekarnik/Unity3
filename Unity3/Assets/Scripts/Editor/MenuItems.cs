using System;
using UnityEngine;
using UnityEditor;

namespace FPS.Editor
{
	public class MenuItems
	{
		[MenuItem("Assets/GeekBrains")]
		private static void LoadAdditiveScene()
		{

		}
		[MenuItem("Assets/Create/GeekBrains")]
		private static void AddConfig()
		{

		}
		[MenuItem("CONTEXT/Rigidbody/Geekbrains")]
		private static void NewOpenForRigidbody()
		{

		}
		[MenuItem("Geekbrains/Пункт меню №0")]
		private static void MenuOption()
		{

		}
		[MenuItem("Geekbrains/Пункт меню №1 %#a")]
		private static void NewMenuOption()
		{

		}
		[MenuItem("Geekbrains/Пункт меню №2 %g")]
		private static void NewNestedOption()
		{

		}
		[MenuItem("Geekbrains/Пункт меню №3 _g")]
		private static void NewOptionWithHotkey()
		{

		}
	}
}
