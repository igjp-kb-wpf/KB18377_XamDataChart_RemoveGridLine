using KB18377_WpfApp1.Model;
using System.Collections.ObjectModel;

namespace KB18377_WpfApp1;

class MainWindowViewModel
{
    public ObservableCollection<GradeFrequencyDistribution> GradeFrequencyDistributions { get; set; } = new ObservableCollection<GradeFrequencyDistribution>();

    public MainWindowViewModel()
    {
        var data = new[]
        {
            ("0〜9",     2),
            ("10〜19",   0),
            ("20〜29",   2),
            ("30〜39",   5),
            ("40〜49",   9),
            ("50〜59",  16),
            ("60〜69",  26),
            ("70〜79",  25),
            ("80〜89",  14),
            ("90〜100",  6),
        };

        foreach (var (grade, freq) in data)
        {
            GradeFrequencyDistributions.Add(new GradeFrequencyDistribution { Grade = grade, Frequency = freq });
        }
    }
}
