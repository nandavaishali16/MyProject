using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public partial class Default : Component
    {
        public Default()
        {
            InitializeComponent();
        }

        public Default(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
