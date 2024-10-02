package tile;

import java.awt.Graphics2D;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;

import javax.imageio.ImageIO;

import Main.GamePanel;

public class TileManager {
GamePanel gp;
Tile[] tile;
 public TileManager(GamePanel gp) {
	 
	 this.gp = gp;
	 
	 tile = new Tile[10];
	 
	 getTileImage();
 }
 
 public void getTileImage() {
	 
	 try {
		 File file = new File("res/tiles/grass.png");
         FileInputStream fis = new FileInputStream(file);
         tile[0] = new Tile();
         tile[0].image = ImageIO.read(fis);

         file = new File("res/tiles/wall.png");
         fis = new FileInputStream(file);
         tile[1] = new Tile();
         tile[1].image = ImageIO.read(fis);

         file = new File("res/tiles/water.png");
         fis = new FileInputStream(file);
         tile[2] = new Tile();
         tile[2].image = ImageIO.read(fis);
	 }catch(IOException e) {
		 e.printStackTrace();
	 }
 }
 
 
 
 
 public void draw(Graphics2D g2) {
	 g2.drawImage(tile[0].image, 0, 0, gp.tileSize, gp.tileSize,null);
	 g2.drawImage(tile[0].image, 48, 0, gp.tileSize, gp.tileSize,null);
	 g2.drawImage(tile[0].image, 96, 0, gp.tileSize, gp.tileSize,null);
	 g2.drawImage(tile[0].image, 192, 0, gp.tileSize, gp.tileSize,null);
	 g2.drawImage(tile[0].image, 384, 0, gp.tileSize, gp.tileSize,null);
	 g2.drawImage(tile[0].image, 768, 0, gp.tileSize, gp.tileSize,null);
	
 }
}
