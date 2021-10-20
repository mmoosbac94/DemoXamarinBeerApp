package crc641de16f1818c0c055;


public class MainFragment
	extends crc6465b117471a9cc96e.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("BeerApp.Droid.Views.Main.MainFragment, BeerApp.Droid", MainFragment.class, __md_methods);
	}


	public MainFragment ()
	{
		super ();
		if (getClass () == MainFragment.class)
			mono.android.TypeManager.Activate ("BeerApp.Droid.Views.Main.MainFragment, BeerApp.Droid", "", this, new java.lang.Object[] {  });
	}


	public MainFragment (int p0)
	{
		super (p0);
		if (getClass () == MainFragment.class)
			mono.android.TypeManager.Activate ("BeerApp.Droid.Views.Main.MainFragment, BeerApp.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
