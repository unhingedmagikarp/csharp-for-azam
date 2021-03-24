import org.junit.Test;
import static org.junit.Assert.*;

public class TestSubInt {

  @Test
  public void testHappyCase() {
    assertArrayEquals(new int[] {0, 1, 4}, SubInt.subInt(1, new int[] {1, 11, 34, 52, 61}));
   }

  @Test
  public void testSadCase() {
    assertArrayEquals(new int[] {}, SubInt.subInt(9, new int[] {1, 11, 34, 52, 61}));
   }
}
