package mvvmcross.droidx.recyclerview;


public class MvxGuardedLinearLayoutManager
	extends androidx.recyclerview.widget.LinearLayoutManager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_supportsPredictiveItemAnimations:()Z:GetSupportsPredictiveItemAnimationsHandler\n" +
			"n_onLayoutChildren:(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)V:GetOnLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler\n" +
			"";
		mono.android.Runtime.register ("MvvmCross.DroidX.RecyclerView.MvxGuardedLinearLayoutManager, MvvmCross.DroidX.RecyclerView", MvxGuardedLinearLayoutManager.class, __md_methods);
	}


	public MvxGuardedLinearLayoutManager (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MvxGuardedLinearLayoutManager.class)
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxGuardedLinearLayoutManager, MvvmCross.DroidX.RecyclerView", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MvxGuardedLinearLayoutManager (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == MvxGuardedLinearLayoutManager.class)
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxGuardedLinearLayoutManager, MvvmCross.DroidX.RecyclerView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public MvxGuardedLinearLayoutManager (android.content.Context p0, int p1, boolean p2)
	{
		super (p0, p1, p2);
		if (getClass () == MvxGuardedLinearLayoutManager.class)
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.RecyclerView.MvxGuardedLinearLayoutManager, MvvmCross.DroidX.RecyclerView", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean supportsPredictiveItemAnimations ()
	{
		return n_supportsPredictiveItemAnimations ();
	}

	private native boolean n_supportsPredictiveItemAnimations ();


	public void onLayoutChildren (androidx.recyclerview.widget.RecyclerView.Recycler p0, androidx.recyclerview.widget.RecyclerView.State p1)
	{
		n_onLayoutChildren (p0, p1);
	}

	private native void n_onLayoutChildren (androidx.recyclerview.widget.RecyclerView.Recycler p0, androidx.recyclerview.widget.RecyclerView.State p1);

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
