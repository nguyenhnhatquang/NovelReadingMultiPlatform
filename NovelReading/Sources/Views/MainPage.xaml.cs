using CommunityToolkit.Maui.Core.Primitives;

namespace NovelReading;

public partial class MainPage : ContentPage
{
	// 1 giây -> 10000000 ticks
	private IEnumerable<Locale> _locales;
	CancellationTokenSource cts;
	public MainPage()
	{
        InitializeComponent();

        MediaElementAudio.Source = "https://c3-ex-swe.nixcdn.com/NhacCuaTui2040/MuaThangSau-VanMaiHuongGREYDTrungQuanIdol-9534954.mp3?st=M0D6REK5fda0sq_k31WeVw&e=1687934540&t=1687333494952";
    }

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		//
		// _locales = await TextToSpeech.GetLocalesAsync();
		//
		// foreach (var l in _locales)
		// 	Languages.Items.Add(l.Name);
	}
	// private async void Button_OnClicked(object sender, EventArgs e)
	// {
	// 	// if (Languages.SelectedIndex > 0)
	// 	// {
	// 	// 	cts = new CancellationTokenSource();
	// 	// 	await TextToSpeech.SpeakAsync(TextToSpeak.Text, new SpeechOptions
	// 	// 	{
	// 	// 		Locale = _locales.Single(l => l.Name == Languages.SelectedItem.ToString()),
	// 	// 		Volume = (float) Volume.Value/10,
	// 	// 		Pitch = (float) Pitch.Value/10
	// 	// 	}, cts.Token);
	// 	// }
	// }

	// private void ButtonStop_OnClicked(object sender, EventArgs e)
	// {
	// 	if (cts?.IsCancellationRequested ?? true)
	// 		return;
	//
	// 	cts.Cancel();
	// }

	private void MediaElementAudio_OnPositionChanged(object sender, MediaPositionChangedEventArgs e)
	{
		var a = (double) MediaElementAudio.Position.Ticks / MediaElementAudio.Duration.Ticks;
		MyProgress.Progress = a;
	}

	private void ButtonNext_OnClicked(object sender, EventArgs e)
	{
		MediaElementAudio.SeekTo(new TimeSpan(MediaElementAudio.Position.Ticks + new TimeSpan(0, 0, 10).Ticks));
	}

	private void ButtonStart_OnClicked(object sender, EventArgs e)
	{
		MediaElementAudio.Play();
	}

	private void ButtonBack_OnClicked(object sender, EventArgs e)
	{
		MediaElementAudio.SeekTo(new TimeSpan(MediaElementAudio.Position.Ticks - new TimeSpan(0, 0, 10).Ticks));
	}

	private void ButtonPause_OnClicked(object sender, EventArgs e)
	{
		MediaElementAudio.Pause();
	}
}

