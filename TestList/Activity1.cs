using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestList
{
	[Activity (Label = "TestList", MainLauncher = true)]
	public class Activity1 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
			ListView listview = FindViewById<ListView> (Resource.Id.listView);
			
			List<Item> items = new List<Item> (200);
			
			for (int i=0; i<200; i++) {
				items.Add (new Item (){
					p1 = "Header " + i,
					p2 = "Description" + i
				});
			}
			
			listview.Adapter = new ItemAdapter (this, Resource.Layout.ListItem, items);
		}
	}
	
	
	
	class Item
	{
		public string p1;
		public string p2;
	}
	
	
	
	class ItemAdapter : ArrayAdapter<Item>
	{
		int _textViewResourceId;
		
		
		
		public ItemAdapter (Context context, int textViewResourceId, List<Item> items) :
		base(context, textViewResourceId, items)
		{	
			_textViewResourceId = textViewResourceId;
		}
		
		
		
		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View v = convertView;
			
			var vi = (LayoutInflater)Context.GetSystemService (Context.LayoutInflaterService);
			v = vi.Inflate (_textViewResourceId, null);
			
			var item = (Item)GetItem (position);
			
			if (item != null) {
				
				var text1 = (TextView)v.FindViewById (Resource.Id.text1);
				if (text1 != null) {
					text1.Text = item.p1;
				}
		
				var text2 = (TextView)v.FindViewById (Resource.Id.text2);
				if (text2 != null) {
					text2.Text = item.p2;
				}
			}
			
			return v;
		}
	}
}


