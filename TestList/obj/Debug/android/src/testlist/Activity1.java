package testlist;


public class Activity1
	extends android.app.Activity
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TestList.Activity1, TestList, Version=1.0.4315.32432, Culture=neutral, PublicKeyToken=null", Activity1.class, __md_methods);
	}

	public Activity1 ()
	{
		super ();
		if (getClass () == Activity1.class)
			mono.android.TypeManager.Activate ("TestList.Activity1, TestList, Version=1.0.4315.32432, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	@Override
	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
