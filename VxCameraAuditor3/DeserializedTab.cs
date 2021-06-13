using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VxCameraAuditor3
{

    public class vxTabUpdate
    {
        public string tab_id { get; set; }
        public string originator_tab_instance_id { get; set; }
        public int sequence_number { get; set; }
        public vxTabData tab { get; set; }
        public CellGridDefinition cell_grid_definition { get; set; }
        public CommonHeader common_header { get; set; }
        public string originators_name { get; set; }
    }

    public class CellGridDefinition
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public List<CellCoords> Cells { get; set; }
    }

    public class CellCoords
    {
        public int i { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int h { get; set; }
        public int w { get; set; }
    }


    public class vxTabData
    {
        public CommonHeader common_header { get; set; }
        public string modified_date { get; set; }
        public string tab_type { get; set; }
        public string collaboration_option { get; set; }
        public string SavedID { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string current_layout_id { get; set; }
        public int ActiveCellIndex { get; set; }
        public List<Cell> cells { get; set; }
        public object KeyboardShortcut { get; set; }
        public object InvestigationStartTime { get; set; }
        public object InvestigationEndTime { get; set; }
        public object InvestigationCurrentTime { get; set; }
        public object InvestigationTimelineControlRowHeight { get; set; }
        public List<object> trim_clips { get; set; }
        public string ExportPlaylistModelSerialized { get; set; }
        public object owner { get; set; }
        public object current_sync_playback_state { get; set; }
        public object maximized_cell_index { get; set; }
    }

    public class PlaybackState
    {
        public string vcr_mode { get; set; }
        public double speed { get; set; }
        public string timestamp { get; set; }
        public string start_range { get; set; }
        public string end_range { get; set; }
        public double playback_scope_in_minutes { get; set; }
    }

    public class SyncPlaybackState
    {
        public string vcr_mode { get; set; }
        public double speed { get; set; }
        public string timestamp { get; set; }
        public string start_range { get; set; }
        public string end_range { get; set; }
        public double playback_scope_in_minutes { get; set; }
    }

    public class ImmersiveCoordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public bool IsZero { get; set; }
    }

    public class PtzState
    {
        public double zoom_percentage { get; set; }
        public string crop_bounds { get; set; }
        public string video_resolution { get; set; }
        public ImmersiveCoordinate immersive_coordinate { get; set; }
    }

    public class Cell
    {
        public string cell_id { get; set; }
        public string content_type { get; set; }
        public string data_source_id { get; set; }
        public object plugin_key { get; set; }
        public object plugin_id { get; set; }
        public object plugin_state { get; set; }
        public object playback_state { get; set; }
        public bool is_in_sync { get; set; }
        public bool is_in_sync_group { get; set; }
        public object sync_playback_state { get; set; }
        public int ptz_status { get; set; }
        public PtzState ptz_state { get; set; }
        public int video_rotation { get; set; }
        public object collaborative_playback_state { get; set; }
    }








}
