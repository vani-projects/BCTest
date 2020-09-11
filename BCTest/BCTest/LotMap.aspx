<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LotMap.aspx.cs" Inherits="BCTest.LotMap" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Lot map is shown below</h3>
    <div id="divDisplay">
        <canvas id="lotmap" width="830" height="560" />
    </div>
    <script>
        var mapSprite = new Image();
        mapSprite.src = "images/lotmap.jpg";
        var greenDot = new Image();
        greenDot.src = "images/green_dot.jpeg";
        $(document).ready(function () {
            $.ajax({
                type: "GET",
                url: "LotMapService.asmx/GetLots",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    var canvas = $("#lotmap");
                    var context = canvas[0].getContext("2d");

                    // Map sprite
                    

                    var Marker = function () {
                        this.Sprite = greenDot;
                        this.Width = 8;
                        this.Height = 8;
                        this.XPos = 0;
                        this.YPos = 0;
                    }

                    var Markers = new Array();

                    msg.d.forEach(element => {
                        var marker = new Marker();
                        marker.XPos = element.X_CoOrd - (marker.Width / 2);
                        marker.YPos = element.Y_CoOrd - (marker.Height/2);

                        Markers.push(marker);
                    });

                    var draw = function (selectedX, selectedY, label) {
                        // Clear Canvas
                        context.fillStyle = "#000";
                        context.fillRect(0, 0, canvas.width, canvas.height);

                        // Draw map
                        // Sprite, X location, Y location, Image width, Image height
                        // You can leave the image height and width off, if you do it will draw the image at default size
                        context.drawImage(mapSprite, 0, 0);

                        // Draw markers
                        for (var i = 0; i < Markers.length; i++) {
                            var tempMarker = Markers[i];
                            // Draw marker
                            context.drawImage(tempMarker.Sprite, tempMarker.XPos, tempMarker.YPos, tempMarker.Width, tempMarker.Height);

                            // Calculate postion text
                            //var markerText = "Postion (X:" + tempMarker.XPos + ", Y:" + tempMarker.YPos;

                            // Draw a simple box so you can see the position
                            //var textMeasurements = context.measureText(markerText);
                            context.fillStyle = "#666";
                            context.globalAlpha = 0.7;
                            //context.fillRect(tempMarker.XPos - (textMeasurements.width / 2), tempMarker.YPos - 15, textMeasurements.width, 20);
                            context.globalAlpha = 1;

                            // Draw position above
                            context.fillStyle = "#000";
                            //context.fillText(markerText, tempMarker.XPos, tempMarker.YPos);
                        }
                    };

                    draw();
                },
                error: function (msg) {
                    console.log("Error:" + msg);
                }
            });
        });

    </script>
</asp:Content>
