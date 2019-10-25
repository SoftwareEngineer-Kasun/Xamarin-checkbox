CheckBox checkMe = FindViewById<CheckBox>(Resource.Id.checkBox1); 
checkMe.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e) => { 
   CheckBox check = (CheckBox)sender; 
   if(check.Checked) { 
      check.Text = "Checkbox has been checked"; 
   } else { 
      check.Text = "Checkbox has not been checked"; 
   } 
};
