package digital.and;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

/**
 * Created by ppop on 19/05/2017.
 */
public class TestApp {

    private App app;

    @Before
    public void before() {
        app = new App();
    }

    @Test
    public void testApp() {
        assertEquals(app.sayHi(), "Hi");
    }
}
