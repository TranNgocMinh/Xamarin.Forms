public  MainPage(string name)
   {
            InitializeComponent();
            var lbName = this.FindByName<Label>("name");
            lbName.Text += name;    
    }
