using Dernek.Application.Repositories.Member;
using Dernek.Core.Entities;
using Dernek.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Dernek.PL
{
    public partial class Home : UserControl
    {
        private readonly IMemberReadRepository _memberReadRepository;
        public Home(IMemberReadRepository memberReadRepository)
        {
            _memberReadRepository = memberReadRepository;
            InitializeComponent();
        }

        private void ConfigureGraph()
        {
            MemberEntity[] members = _memberReadRepository.GetAll().ToArray();
            City[] memberCities = members.Select(m => m.City).ToArray();

            string[] cityNames = Array.ConvertAll(memberCities, c => Enum.GetName(typeof(City), c));
            cityNames = cityNames.Distinct().ToArray();

            Dictionary<string, double> cityMemberCounts = new();
            foreach (string cityName in cityNames)
            {
                int count = members.Count(m => Enum.GetName(typeof(City), m.City) == cityName);
                cityMemberCounts.Add(cityName, count);
            }
            GraphPane cityGraphPane = cityGraph.GraphPane;
            cityGraphPane.Title.Text = "Şehirlere Göre Üye Dağılımı";
            cityGraphPane.XAxis.Title.Text = "Şehirler";
            cityGraphPane.YAxis.Title.Text = "Üye Sayısı";
            cityGraphPane.XAxis.Scale.TextLabels = cityNames;
            cityGraphPane.XAxis.Type = AxisType.Text;
            cityGraphPane.YAxis.Scale.MajorStep = 1;
            cityGraphPane.YAxis.Scale.MinorStep = 1;

            BarItem cityBar = cityGraphPane.AddBar("Üyeler", null, cityMemberCounts.Values.ToArray(), System.Drawing.Color.Blue);
            cityBar.Bar.Fill = new(System.Drawing.Color.AliceBlue);
            cityGraph.AxisChange();

        }

        private void Home_Load(object sender, EventArgs e)
        {

            ConfigureGraph();


        }

        private void CityGraph_Zoom(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            GraphPane graphPane = cityGraph.GraphPane;
            if (graphPane.YAxis.Scale.Min < 0)
            {
                graphPane.YAxis.Scale.Min = 0;
                cityGraph.AxisChange();
                cityGraph.Invalidate();
            }
        }
    }
}
