// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class DashboardsExtensions
    {
            /// <summary>
            /// Returns the EntitySet dashboards
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            public static ODataResponseListDashboard GetDashboardsByGroup(this IDashboards operations, string group, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetDashboardsByGroupAsync(group, expand, filter, select, orderby, top, skip, count), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the EntitySet dashboards
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListDashboard> GetDashboardsByGroupAsync( this IDashboards operations, string group, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardsByGroupWithHttpMessagesAsync(group, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the EntitySet dashboards
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            public static ODataResponseListDashboard GetDashboards(this IDashboards operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetDashboardsAsync(expand, filter, select, orderby, top, skip, count), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the EntitySet dashboards
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListDashboard> GetDashboardsAsync( this IDashboards operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardsWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            public static Dashboard GetDashboardByGroup(this IDashboards operations, string group, string dashboardKey)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetDashboardByGroupAsync(group, dashboardKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dashboard> GetDashboardByGroupAsync( this IDashboards operations, string group, string dashboardKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardByGroupWithHttpMessagesAsync(group, dashboardKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            public static ODataResponseListTile GetTilesByGroup(this IDashboards operations, string group, string dashboardKey)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetTilesByGroupAsync(group, dashboardKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListTile> GetTilesByGroupAsync( this IDashboards operations, string group, string dashboardKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTilesByGroupWithHttpMessagesAsync(group, dashboardKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            public static object PostTileByGroup(this IDashboards operations, string group, string dashboardKey, Tile tile)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).PostTileByGroupAsync(group, dashboardKey, tile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostTileByGroupAsync( this IDashboards operations, string group, string dashboardKey, Tile tile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostTileByGroupWithHttpMessagesAsync(group, dashboardKey, tile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            public static Tile GetTileByGroup(this IDashboards operations, string group, string dashboardKey, string tileKey, string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetTileByGroupAsync(group, dashboardKey, tileKey, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> GetTileByGroupAsync( this IDashboards operations, string group, string dashboardKey, string tileKey, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTileByGroupWithHttpMessagesAsync(group, dashboardKey, tileKey, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            public static Tile PutTileByGroup(this IDashboards operations, string group, string dashboardKey, string tileKey, Tile tile)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).PutTileByGroupAsync(group, dashboardKey, tileKey, tile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> PutTileByGroupAsync( this IDashboards operations, string group, string dashboardKey, string tileKey, Tile tile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutTileByGroupWithHttpMessagesAsync(group, dashboardKey, tileKey, tile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='patchTile'>
            /// </param>
            public static Tile PatchTileByGroup(this IDashboards operations, string group, string dashboardKey, string tileKey, object patchTile)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).PatchTileByGroupAsync(group, dashboardKey, tileKey, patchTile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='group'>
            /// The organizational group
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='patchTile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> PatchTileByGroupAsync( this IDashboards operations, string group, string dashboardKey, string tileKey, object patchTile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchTileByGroupWithHttpMessagesAsync(group, dashboardKey, tileKey, patchTile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            public static Dashboard GetDashboardByDashboardkey(this IDashboards operations, string dashboardKey)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetDashboardByDashboardkeyAsync(dashboardKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dashboard> GetDashboardByDashboardkeyAsync( this IDashboards operations, string dashboardKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardByDashboardkeyWithHttpMessagesAsync(dashboardKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            public static ODataResponseListTile GetTilesByDashboardkey(this IDashboards operations, string dashboardKey)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetTilesByDashboardkeyAsync(dashboardKey), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListTile> GetTilesByDashboardkeyAsync( this IDashboards operations, string dashboardKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTilesByDashboardkeyWithHttpMessagesAsync(dashboardKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            public static object PostTileByDashboardkey(this IDashboards operations, string dashboardKey, Tile tile)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).PostTileByDashboardkeyAsync(dashboardKey, tile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostTileByDashboardkeyAsync( this IDashboards operations, string dashboardKey, Tile tile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostTileByDashboardkeyWithHttpMessagesAsync(dashboardKey, tile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            public static Tile GetTileByDashboardkeyAndTilekey(this IDashboards operations, string dashboardKey, string tileKey, string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).GetTileByDashboardkeyAndTilekeyAsync(dashboardKey, tileKey, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> GetTileByDashboardkeyAndTilekeyAsync( this IDashboards operations, string dashboardKey, string tileKey, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTileByDashboardkeyAndTilekeyWithHttpMessagesAsync(dashboardKey, tileKey, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            public static Tile PutTileByDashboardkeyAndTilekey(this IDashboards operations, string dashboardKey, string tileKey, Tile tile)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).PutTileByDashboardkeyAndTilekeyAsync(dashboardKey, tileKey, tile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='tile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> PutTileByDashboardkeyAndTilekeyAsync( this IDashboards operations, string dashboardKey, string tileKey, Tile tile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutTileByDashboardkeyAndTilekeyWithHttpMessagesAsync(dashboardKey, tileKey, tile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='patchTile'>
            /// </param>
            public static Tile PatchTileByDashboardkeyAndTilekey(this IDashboards operations, string dashboardKey, string tileKey, object patchTile)
            {
                return Task.Factory.StartNew(s => ((IDashboards)s).PatchTileByDashboardkeyAndTilekeyAsync(dashboardKey, tileKey, patchTile), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dashboardKey'>
            /// </param>
            /// <param name='tileKey'>
            /// </param>
            /// <param name='patchTile'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> PatchTileByDashboardkeyAndTilekeyAsync( this IDashboards operations, string dashboardKey, string tileKey, object patchTile, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchTileByDashboardkeyAndTilekeyWithHttpMessagesAsync(dashboardKey, tileKey, patchTile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
