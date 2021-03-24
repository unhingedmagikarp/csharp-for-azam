import org.junit.Test;
import static org.junit.Assert.*;

public class TestUnique {

  @Test
  public void testHappyCase() {
    assertArrayEquals(new int[]{1, 11, 34, 52, 61}, 
      Unique.unique(new int[]{1, 11, 34, 11, 52, 61, 1, 34}));
   }
}
