/**
 * Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package helloworld.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The Greeting model.
 */
public class Greeting {
    /**
     * Greeting text
     */
    @JsonProperty(required = true)
    private String text;

    /**
     * Get the text value.
     *
     * @return the text value
     */ 
    public String getText() {
        return this.text;
    }

    /**
     * Set the text value.
     *
     * @param text the text value to set
     */
    public void setText(String text) {
        this.text = text;
    }

}
