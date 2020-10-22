protected void lkb_EDIT_QMOMO_Click(object sender, EventArgs e)
        {
 
            GridViewRow gvrChild = (GridViewRow)((Control)sender).Parent.Parent;
            GridViewRow gvrParent = (GridViewRow)gvrChild.Parent.Parent.Parent.Parent;
 
            HiddenField hidCHECKID = (HiddenField)gvrParent.FindControl("hidCHECKID");
            LinkButton lblQMIS_NO = (LinkButton)gvrChild.FindControl("lkb_QIMS_NO");  //V0015 mark
		}