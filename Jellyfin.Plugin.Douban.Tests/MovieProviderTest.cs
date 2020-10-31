// using System;
// using System.Threading;
// using Jellyfin.Plugin.Douban.Tests.Mock;
// using MediaBrowser.Controller.Providers;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Logging;
// using Xunit;

// namespace Jellyfin.Plugin.Douban.Tests
// {
//     public class MovieProviderTest
//     {
//         private readonly MovieProvider _doubanProvider;
//         private readonly IServiceProvider _serviceProvider;

//         public MovieProviderTest()
//         {
//             _serviceProvider = new ServiceCollection().AddLogging(builder => builder.AddConsole())
//                                                       .BuildServiceProvider();
//             var loggerFactory = _serviceProvider.GetService<ILoggerFactory>();
//             var logger = loggerFactory.CreateLogger<MovieProvider>();

//             var httpClient = new MockHttpClient();
//             var jsonSerializer = new MockJsonSerializer();
//             _doubanProvider = new MovieProvider(httpClient, jsonSerializer, logger);
//         }

//         [Fact]
//         public void TestGetMetadata()
//         {
//             MovieInfo info = new MovieInfo()
//             {
//                 Name = "蝴蝶效应"
//             };

//             // Test 1: normal test.
//             var meta = _doubanProvider.GetMetadata(info, CancellationToken.None).Result;
//             Assert.True(meta.HasMetadata);

//             // Test 2: can not get the result.
//             info = new MovieInfo()
//             {
//                 MetadataLanguage = "zh",
//                 Name = "奇迹男孩"
//             };
//             meta = _doubanProvider.GetMetadata(info, CancellationToken.None).Result;
//             Assert.True(meta.HasMetadata);

//             // Test 3: test rare movie.
//             info = new MovieInfo()
//             {
//                 Name = "哪吒"
//             };
//             meta = _doubanProvider.GetMetadata(info, CancellationToken.None).Result;
//             Assert.True(meta.HasMetadata);
//         }
//     }
// }
