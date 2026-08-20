using HydroxideMenu.features;
using UnityEngine;

namespace HydroxideMenu.ui.sections
{
	internal class GeneralSection : ISection
	{
		public GeneralSection() : base("General") { }

		public override void Render() {
			GUILayout.Label("hi welcom to hydroxide do whatever but dont blame me for getting banned lol thank for use");

			Chat.OnChat.LogChatMessages = GUILayout.Toggle(Chat.OnChat.LogChatMessages, "Log chat messages to console");

			if(GUILayout.Button("Clear Notifications"))
			{
				Hydra.notifications.ClearNotifications();
				Hydra.notifications.Send("Notifications", "All notifications have been cleared.", 5);
			}
		}
	}
}
